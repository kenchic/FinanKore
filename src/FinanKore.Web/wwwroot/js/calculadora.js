window.fkCalculadoraTeclado = (function () {
    let handler = null;

    return {
        registrar: function (dotnetRef) {
            if (handler) return;
            handler = function (e) {
                dotnetRef.invokeMethodAsync('OnTeclaPresionada', e.key);
            };
            document.addEventListener('keydown', handler);
        },
        limpiar: function () {
            if (handler) {
                document.removeEventListener('keydown', handler);
                handler = null;
            }
        }
    };
})();
