window.fkTema = {
    nombreCookie: 'fk-tema',

    obtenerTema: function () {
        var match = document.cookie.match(new RegExp('(^| )' + this.nombreCookie + '=([^;]+)'));
        return match ? match[2] : 'light';
    },

    establecerTema: function (tema) {
        tema = tema || 'light';
        document.documentElement.setAttribute('data-bs-theme', tema);
        document.cookie = this.nombreCookie + '=' + tema + ';path=/;max-age=31536000;SameSite=Lax';
    },

    alternarTema: function () {
        var actual = this.obtenerTema();
        var nuevo = actual === 'dark' ? 'light' : 'dark';
        this.establecerTema(nuevo);
        return nuevo;
    },

    iniciar: function () {
        var tema = this.obtenerTema();
        this.establecerTema(tema);

        var self = this;
        var observer = new MutationObserver(function () {
            var actual = document.documentElement.getAttribute('data-bs-theme');
            var cookie = self.obtenerTema();
            if (actual !== cookie) {
                document.documentElement.setAttribute('data-bs-theme', cookie);
            }
        });
        observer.observe(document.documentElement, {
            attributes: true,
            attributeFilter: ['data-bs-theme']
        });
    }
};

fkTema.iniciar();