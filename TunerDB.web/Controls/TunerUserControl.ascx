<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TunerUserControl.ascx.cs" Inherits="Controls_TunerUserControl" %>

  <meta charset="utf-8">
  <link rel="stylesheet" href="../Content/styles.css">
 
         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-md-3' style=" margin-top:10px; margin-left:20px; position:absolute;" >
         <asp:DropDownList runat="server" ID="Listbox" Style="position:absolute;" CssClass="btn btn-info dropdown-toggle"> </asp:DropDownList>
         </div>
         </div>

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-md-3' style=" margin-top:10px; margin-left:135px; position:absolute;" >
         <asp:Button ID ="log" runat="server" OnClick="Unnamed_Click" Text="Log" Style="position:absolute;" CssClass="btn btn-info" /> 
         </div>

         </div> 

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-lg-3' style=" margin-top:55px; margin-left:90px; position:absolute;" >
         <p style="color:#FFFFFF; font-weight: bold;">1st</p>
         </div>
         </div>

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-lg-3' style=" margin-top:50px; margin-left:135px; position:absolute;" >
         <asp:DropDownList runat="server" ID="Listbox1" Style="position:absolute;" CssClass="btn btn-info dropdown-toggle">
         <asp:ListItem Text="Na" Value="0"></asp:ListItem>
         </asp:DropDownList>
         </div>
         </div>

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-lg-3' style=" margin-top:95px; margin-left:90px; position:absolute;" >
         <p style="color:#FFFFFF; font-weight: bold;">2nd</p>
         </div>
         </div>

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-md-3' style=" margin-top:90px; margin-left:135px; position:absolute;" >
         <asp:DropDownList runat="server" ID="Listbox2" Style="position:absolute;" CssClass="btn btn-info dropdown-toggle">
         <asp:ListItem Text="Na" Value="0"></asp:ListItem>
         </asp:DropDownList>
         </div>
         </div>

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-lg-3' style=" margin-top:135px; margin-left:90px; position:absolute;" >
         <p style="color:#FFFFFF; font-weight: bold;">3rd</p>
         </div>
         </div> 
        
         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-md-3' style=" margin-top:130px; margin-left:135px; position:absolute;" >
         <asp:DropDownList runat="server" ID="Listbox3" Style="position:absolute;" CssClass="btn btn-info dropdown-toggle">
         <asp:ListItem Text="Na" Value="0"></asp:ListItem>
         </asp:DropDownList>
         </div>
         </div>
     
         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-lg-3' style=" margin-top:175px; margin-left:90px; position:absolute;" >
         <p style="color:#FFFFFF; font-weight: bold;">4th</p>
         </div>
         </div>
         
         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-md-3' style=" margin-top:170px; margin-left:135px; position:absolute;" >
         <asp:DropDownList runat="server" ID="Listbox4" Style="position:absolute;" CssClass="btn btn-info dropdown-toggle">
         <asp:ListItem Text="Na" Value="0"></asp:ListItem>
         </asp:DropDownList>
         </div>
         </div>

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-lg-3' style=" margin-top:215px; margin-left:90px; position:absolute;" >
         <p style="color:#FFFFFF; font-weight: bold;">5th</p>
         </div>
         </div>
         
         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-md-3' style=" margin-top:210px; margin-left:135px; position:absolute;" >
         <asp:DropDownList runat="server" ID="Listbox5" Style="position:absolute;" CssClass="btn btn-info dropdown-toggle">
         <asp:ListItem Text="Na" Value="0"></asp:ListItem>
         </asp:DropDownList>
         </div>
         </div>

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-lg-3' style=" margin-top:255px; margin-left:90px; position:absolute;" >
         <p style="color:#FFFFFF; font-weight: bold;">6th</p>
         </div>
         </div>

         <div class="row" style="position:absolute" z-index:999;>
         <div class ='col-md-3' style=" margin-top:250px; margin-left:135px; position:absolute;" >
         <asp:DropDownList runat="server" ID="Listbox6" Style="position:absolute;" CssClass="btn btn-info dropdown-toggle">
         <asp:ListItem Text="Na" Value="0"></asp:ListItem>
         </asp:DropDownList>
         </div>
         </div>

    <div class="fft" style="margin-top: -20px;">
<script>
    function fft() {
        setup();
    }
    function setup() {
        createCanvas(windowWidth*.99, windowHeight*0.9);
        noFill();
        stroke(100, 100, 100);


        mic = new p5.AudioIn();
        mic.start();
        fft = new p5.FFT(0.6, 2048);
        fft.setInput(mic);
        draw();
    }

        function draw() {
            background(0, 0, 0, 30);

            var spectrum = fft.analyze();

            beginShape();
            for (i = 0; i < spectrum.length; i++) {
                vertex(i*1.33, map(spectrum[i], 0, 300, height, 0));
            }
            endShape();
        }
</script>

</div>

