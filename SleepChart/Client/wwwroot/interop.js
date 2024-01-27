window.interop = {
    getWindowWidth: function () {
        return window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;
    },

    getWindowHeight: function () {
        return window.innerHeight || document.documentElement.clientHeight || document.body.clientHeight;
    }
};