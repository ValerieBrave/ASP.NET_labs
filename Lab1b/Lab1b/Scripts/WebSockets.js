var ta;
var ws = null;
var bstart;
var bstop;

window.onload = function () {
    if (Modernizr.websockets) {
        WriteMessage('support', 'да');
        ta = document.getElementById('ta');
        this.bstart = this.document.getElementById('bstart');
        this.bstop = this.document.getElementById('bstop');
        this.bstart.disabled = false;
        this.bstop.disabled = true;
    }
}

function WriteMessage(idspan, txt) {
    var span = document.getElementById(idspan);
    span.innerHTML = txt;
}

function exe_start() {
    if (ws == null) {
        //ws = new WebSocket('ws://localhost:44334/Websockets.websocket');
        ws = new WebSocket("ws://localhost/websockets.websocket");
        ws.onopen = function () { ws.send('Соединение'); }
        ws.onclose = function (s) { console.log('onclose', s); }
        ws.onmessage = function (evt) { ta.innerHTML += '\n' + evt.data; }
        this.bstart.disabled = true;
        this.bstop.disabled = false;
    }
}

function exe_stop() {
    ws.close(3001, ' stopapplication');
    ws = null;
    this.bstart.disabled = false;
    this.bstop.disabled = true;
}