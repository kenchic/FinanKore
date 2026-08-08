window.fkCalculadoraDrag = (function () {
    let dragState = null;
    let rafId = null;

    const PosicionStorageKey = 'fk_calculadora_pos';

    function clamp(valor, min, max) {
        return Math.max(min, Math.min(max, valor));
    }

    function aplicarTransform(panel, dx, dy) {
        const xInicial = parseFloat(panel.dataset.dragX || '0');
        const yInicial = parseFloat(panel.dataset.dragY || '0');
        const x = xInicial + dx;
        const y = yInicial + dy;

        const maxX = window.innerWidth - panel.offsetWidth;
        const maxY = window.innerHeight - panel.offsetHeight;
        const xc = clamp(x, 0, Math.max(0, maxX));
        const yc = clamp(y, 0, Math.max(0, maxY));

        panel.style.left = xc + 'px';
        panel.style.top = yc + 'px';
        panel.style.right = 'auto';
        panel.style.bottom = 'auto';
        panel.style.transform = 'none';

        panel.dataset.dragCurrentX = xc;
        panel.dataset.dragCurrentY = yc;
    }

    return {
        restaurarPosicion: function (panelId) {
            try {
                const raw = localStorage.getItem(PosicionStorageKey);
                const panel = document.getElementById(panelId);
                if (!panel) return;

                let x = null, y = null;
                if (raw) {
                    const pos = JSON.parse(raw);
                    if (typeof pos.x === 'number' && typeof pos.y === 'number') {
                        x = pos.x;
                        y = pos.y;
                    }
                }

                if (x === null || y === null) {
                    const rect = panel.getBoundingClientRect();
                    const w = rect.width || 320;
                    const h = rect.height || 460;
                    x = Math.max(0, window.innerWidth - w - 24);
                    y = Math.max(0, window.innerHeight - h - 24);
                }

                const maxX = window.innerWidth - (panel.offsetWidth || 320);
                const maxY = window.innerHeight - (panel.offsetHeight || 460);
                x = clamp(x, 0, Math.max(0, maxX));
                y = clamp(y, 0, Math.max(0, maxY));

                panel.style.left = x + 'px';
                panel.style.top = y + 'px';
                panel.style.right = 'auto';
                panel.style.bottom = 'auto';
                panel.style.transform = 'none';

                panel.dataset.dragX = x;
                panel.dataset.dragY = y;
                panel.dataset.dragCurrentX = x;
                panel.dataset.dragCurrentY = y;

                return { x: x, y: y };
            } catch (e) {
                return null;
            }
        },

        iniciar: function (panelId, headerSelector, dotnetRef) {
            const panel = document.getElementById(panelId);
            if (!panel) return;
            const header = panel.querySelector(headerSelector);
            if (!header) return;

            this.detener();

            const onPointerDown = function (e) {
                if (e.target.closest('button, a, input, select, textarea, label')) return;
                if (e.button !== 0 && e.pointerType === 'mouse') return;
                e.preventDefault();
                try { header.setPointerCapture(e.pointerId); } catch { }

                const xInicial = parseFloat(panel.dataset.dragX || '0');
                const yInicial = parseFloat(panel.dataset.dragY || '0');
                dragState = {
                    pointerId: e.pointerId,
                    inicioX: e.clientX,
                    inicioY: e.clientY,
                    xInicial: xInicial,
                    yInicial: yInicial,
                    panel: panel,
                    header: header,
                    dotnetRef: dotnetRef
                };

                panel.classList.add('arrastrando');
            };

            const onPointerMove = function (e) {
                if (!dragState || e.pointerId !== dragState.pointerId) return;
                const dx = e.clientX - dragState.inicioX;
                const dy = e.clientY - dragState.inicioY;

                if (rafId !== null) return;
                rafId = requestAnimationFrame(function () {
                    rafId = null;
                    if (!dragState) return;
                    aplicarTransform(dragState.panel, dx, dy);
                });
            };

            const onPointerUp = function (e) {
                if (!dragState || e.pointerId !== dragState.pointerId) return;
                try { header.releasePointerCapture(e.pointerId); } catch { }

                const x = parseFloat(panel.dataset.dragCurrentX || '0');
                const y = parseFloat(panel.dataset.dragCurrentY || '0');
                panel.dataset.dragX = x;
                panel.dataset.dragY = y;

                panel.classList.remove('arrastrando');

                try {
                    localStorage.setItem(PosicionStorageKey, JSON.stringify({ x: x, y: y }));
                } catch { }

                if (dragState.dotnetRef) {
                    try {
                        dragState.dotnetRef.invokeMethodAsync('OnDragEnd', x, y);
                    } catch { }
                }

                dragState = null;
            };

            header.addEventListener('pointerdown', onPointerDown);
            header.addEventListener('pointermove', onPointerMove);
            header.addEventListener('pointerup', onPointerUp);
            header.addEventListener('pointercancel', onPointerUp);

            dragState = {
                handlers: { onPointerDown: onPointerDown, onPointerMove: onPointerMove, onPointerUp: onPointerUp },
                header: header
            };
        },

        detener: function () {
            if (dragState && dragState.header) {
                const h = dragState.header;
                h.removeEventListener('pointerdown', dragState.handlers.onPointerDown);
                h.removeEventListener('pointermove', dragState.handlers.onPointerMove);
                h.removeEventListener('pointerup', dragState.handlers.onPointerUp);
                h.removeEventListener('pointercancel', dragState.handlers.onPointerUp);
            }
            if (rafId !== null) {
                cancelAnimationFrame(rafId);
                rafId = null;
            }
            dragState = null;
        },

        limpiarPosicion: function () {
            try { localStorage.removeItem(PosicionStorageKey); } catch { }
        }
    };
})();
