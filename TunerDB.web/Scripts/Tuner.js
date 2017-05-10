var Button1  = document.getElementById("C_Button");
var Button2  = document.getElementById("Db_Button");
var Button3  = document.getElementById("D_Button");
var Button4  = document.getElementById("Eb_Button");
var Button5  = document.getElementById("E_Button");
var Button6  = document.getElementById("F_Button");
var Button7  = document.getElementById("Gb_Button");
var Button8  = document.getElementById("G_Button");
var Button9  = document.getElementById("Ab_Button");
var Button10 = document.getElementById("A_Button");
var Button11 = document.getElementById("Bb_Button");
var Button12 = document.getElementById("B_Button");

// this is the C note
Button1.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(261.63);
osc.start();
envelope.play(osc, 0, 0.1);
}



// This is the C# note
Button2.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(277.18);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the D note
Button3.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(293.66);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the Eb note
Button4.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(311.13);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the E note
Button5.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(329.63);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the F note
Button6.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(349.23);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This  is the F# note
Button7.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(369.99);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the G note
Button8.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(392.00);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the G# note
Button9.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(415.30);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the A note
Button10.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(440);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the Bb note
Button11.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(466.16);
osc.start();
envelope.play(osc, 0, 0.1);
}

//This is the B note
Button12.onclick = function setup() {
var osc; var envelope;
envelope = new p5.Env();
envelope.setADSR(0.1, .8, 1.4, 2);
envelope.setRange(1, 0);
osc = new p5.SinOsc(493.88);
osc.start();
envelope.play(osc, 0, 0.1);
}
