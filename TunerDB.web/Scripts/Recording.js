var mic, recorder, soundFile;

var state = 0;

function setup() {

        createCanvas(windowWidth * .99, windowHeight * 0.9);
        noFill();
        stroke(100, 100, 100);
        fft = new p5.FFT(0.6, 2048);
        fft.setInput(mic);

        mic = new p5.AudioIn();
        mic.start();
        recorder = new p5.SoundRecorder();
        recorder.setInput(mic);
        soundFile = new p5.SoundFile();

       button1 = createButton('start');
       button2 = createButton('stop');
       button3 = createButton('play');
       button4 = createButton('save');

       button1.id('startbut');
       button2.id('stopbut');
       button3.id('playbut');
       button4.id('savebut');

       button1.class('btn-lg btn-success');
       button2.class('btn-lg btn-danger');
       button3.class('btn-lg btn-warning');
       button4.class('btn-lg btn-primary');

       button1.position(65, 60);
       button2.position(155, 60);
       button3.position(245, 60);
       button4.position(335, 60);

       button1.mousePressed(start_);
       button2.mousePressed(stop_);
       button3.mousePressed(play_);
       button4.mousePressed(save_);
}


   function draw() {
       background(0, 0, 0, 30);
   
       var spectrum = fft.analyze();
   
       beginShape();
       for (i = 0; i < spectrum.length; i++) {
           vertex(i * 1.33, map(spectrum[i], 0, 300, height, 0));
       }
       endShape();
   }

    function start_()  {
            recorder.record(soundFile);
    }

    function stop_()  {
        recorder.stop();
    }

    function save_() {
        saveSound(soundFile, 'mySound.wav');
    }

    function play_() {
        soundFile.play();
    }