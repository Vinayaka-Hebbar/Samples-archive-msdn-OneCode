# Silverlight 3 pixel shader feature demo (CSSL3PixelShader)
## Requires
* Visual Studio 2008
## License
* Apache License, Version 2.0
## Technologies
* Silverlight
## Topics
* Pixel Shader
## IsPublished
* True
## ModifiedDate
* 2011-05-05 06:15:01
## Description

<p style="font-family:Courier New"></p>
<h2>SILVERLIGHT APPLICATION : CSSL3PixelShader Project Overview</h2>
<p style="font-family:Courier New"></p>
<h3>Use:</h3>
<p style="font-family:Courier New"><br>
This example demonstrates how to use new pixel shader feature in Silverlight3.<br>
It mainly covers two parts:<br>
<br>
1. How to use built-in Effect such as DropShadowEffect.<br>
2. How to create a custom ShaderEffect and use it in the application.<br>
<br>
</p>
<h3>Prerequisites:</h3>
<p style="font-family:Courier New"><br>
Silverlight 3 Tools for Visual Studio 2008 SP1<br>
<a target="_blank" href="http://www.microsoft.com/downloads/details.aspx?familyid=9442b0f2-7465-417a-88f3-5e7b5409e9dd&displaylang=en">http://www.microsoft.com/downloads/details.aspx?familyid=9442b0f2-7465-417a-88f3-5e7b5409e9dd&displaylang=en</a><br>
<br>
Silverilght 3 runtime:<br>
<a target="_blank" href="http://silverlight.net/getstarted/">http://silverlight.net/getstarted/</a><br>
<br>
DirectX SDK: (Not required to run the application but you need fxc tool in it<br>
to create the .ps file if you would like to create the .ps file on your own)<br>
<a target="_blank" href="http://www.microsoft.com/DOWNLOADS/details.aspx?FamilyID=24a541d6-0486-4453-8641-1eee9e21b282&displaylang=en">http://www.microsoft.com/DOWNLOADS/details.aspx?FamilyID=24a541d6-0486-4453-8641-1eee9e21b282&displaylang=en</a><br>
<br>
</p>
<h3>Creation:</h3>
<p style="font-family:Courier New"><br>
A. Create a .ps file to be used in custom ShaderEffect. (Skip this step if <br>
you want to use the existing .ps file in this project directly)<br>
<br>
Step1. Create a new .txt file. Open it and paste following HLSL(High Level <br>
Shader Language) code to it:<br>
<br>
sampler2D input : register(S0);<br>
float2 center:register(C0);<br>
float amplitude:register(C1);<br>
<br>
float4 main(float2 uv : TEXCOORD) : COLOR<br>
{<br>
&nbsp;&nbsp;&nbsp;&nbsp;if(pow((uv.x-center.x),2)&#43;pow((uv.y-center.y),2)&lt;0.15)<br>
&nbsp;&nbsp;&nbsp;&nbsp;{<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;uv.y = uv.y &nbsp;&#43; (sin(uv.y*100)*0.1*amplitude);<br>
&nbsp;&nbsp;&nbsp;&nbsp;}<br>
&nbsp;&nbsp;&nbsp;&nbsp;return tex2D( input , uv.xy);<br>
}<br>
<br>
Step2. Save the .txt file. Close it. Rename it as ovalwatery.fx.<br>
<br>
Step3. Open DirectX SDK Command Prompt and run the following command:<br>
<br>
fxc /T ps_2_0 /Fo &quot;&lt;OutputPath&gt;\ovalwatery.ps&quot; &quot;&lt;InputPath&gt;\ovalwatery.fx&quot;<br>
<br>
The &lt;InputPath&gt; is the path of the .fx file.<br>
The &lt;OutPutpat&gt; is the path of the .ps file you want to create.<br>
<br>
B. Create the Silverlight project.<br>
<br>
Step1. Create a Visual C# Silverlight Application project named <br>
CSSL3PixelShader in Visual Studio 2008 SP1.<br>
<br>
C. Add the .ps file to the project.<br>
<br>
Step1. Right click the project node in the Solution Explorer window, select <br>
Add-&gt; Existing Item to add the .ps file (craeted in step3 of A) to the <br>
project.<br>
<br>
D. Add the &quot;Humpback Whale.jpg&quot; file to the project.<br>
<br>
Step1. Right click the project node in the Solution Explorer window, select<br>
Add-&gt; Existing Item to add the &quot;Humpback Whale.jpg&quot; (you can find it in this
<br>
project) file to the project.<br>
<br>
E. Edit xaml.<br>
<br>
Step1. Double click MainPage.xaml in the Solution Explorer window to view the <br>
xaml code. Replace the &lt;Grid&gt; with the following code:<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp;&lt;Grid x:Name=&quot;LayoutRoot&quot;&gt;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;Grid.RowDefinitions&gt;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;RowDefinition Height=&quot;1*&quot;/&gt;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;RowDefinition Height=&quot;9*&quot;/&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp;&lt;/Grid.RowDefinitions&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp;&lt;TextBlock HorizontalAlignment=&quot;Center&quot; Foreground=&quot;Red&quot; FontSize=&quot;32&quot;
<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Text=&quot;Please Click the Image&quot;&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;TextBlock.Effect&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;DropShadowEffect Color=&quot;Black&quot;&gt; &nbsp; &nbsp;<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/DropShadowEffect&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&lt;/TextBlock.Effect&gt;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/TextBlock&gt;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;Image Grid.Row=&quot;1&quot; Width=&quot;640&quot; Height=&quot;480&quot; &nbsp;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;x:Name=&quot;ImagePixelShader&quot; Source=&quot;Humpback Whale.jpg&quot;&gt;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;/Image&gt;<br>
&nbsp;&nbsp;&nbsp;&nbsp;&lt;/Grid&gt;<br>
<br>
The above code mainly adds two controls:<br>
<br>
A TextBlock used to show how to use the built-in DropShadowEffect.<br>
An Image control used to show how to use custom ShaderEffect.<br>
<br>
Step2. Replace &lt;UserControl&gt; tag with the following code:<br>
<br>
&lt;UserControl x:Class=&quot;CSSL3PixelShader.MainPage&quot;<br>
&nbsp; &nbsp;xmlns=&quot;<a target="_blank" href="http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;">http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;</a>
<br>
&nbsp; &nbsp;xmlns:x=&quot;<a target="_blank" href="http://schemas.microsoft.com/winfx/2006/xaml&quot;">http://schemas.microsoft.com/winfx/2006/xaml&quot;</a><br>
&nbsp; &nbsp;xmlns:d=&quot;<a target="_blank" href="http://schemas.microsoft.com/expression/blend/2008&quot;">http://schemas.microsoft.com/expression/blend/2008&quot;</a>
<br>
&nbsp; &nbsp;xmlns:mc=&quot;<a target="_blank" href="http://schemas.openxmlformats.org/markup-compatibility/2006&quot;">http://schemas.openxmlformats.org/markup-compatibility/2006&quot;</a>
<br>
&nbsp; &nbsp;xmlns:c=&quot;clr-namespace:CSSL3PixelShader&quot; <br>
&nbsp; &nbsp;MouseLeftButtonDown=&quot;UserControl_MouseLeftButtonDown&quot;<br>
&nbsp; &nbsp;mc:Ignorable=&quot;d&quot; d:DesignWidth=&quot;640&quot; d:DesignHeight=&quot;480&quot;&gt;<br>
<br>
This step mainly does two things:<br>
<br>
Hook the MouseLeftButtonDown event of the UserControl:<br>
MouseLeftButtonDown=&quot;UserControl_MouseLeftButtonDown&quot;<br>
<br>
Define a new xmlns:<br>
xmlns:c=&quot;clr-namespace:CSSL3PixelShader&quot;<br>
<br>
F. Edit xaml.cs.<br>
<br>
Step1. Double click MainPage.xaml.cs to view the code. Add following code <br>
after the last &quot;using System.Windows.Shapes;&quot;:<br>
<br>
using System.Windows.Threading;<br>
using System.Windows.Media.Effects;<br>
<br>
Step2. Replace the MainPage class with the following code:<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;public partial class MainPage : UserControl<br>
&nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp;// A timer used to reduce the value of _amplitude gradually.<br>
&nbsp; &nbsp; &nbsp; &nbsp;private DispatcherTimer _timer = new DispatcherTimer();<br>
&nbsp; &nbsp; &nbsp; &nbsp;// Init custom effect<br>
&nbsp; &nbsp; &nbsp; &nbsp;OvalWateryEffect _effect = new OvalWateryEffect(<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;new Uri(@&quot;/CSSL3PixelShader;component/ovalwatery.ps&quot;,<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;UriKind.Relative));<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;public MainPage()<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;InitializeComponent();<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;this.ImageWithPixelShader.Effect = _effect;<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;// Initialize timer and hook Tick event.<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;_timer.Interval = TimeSpan.FromMilliseconds(50);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;_timer.Tick &#43;= new EventHandler(_timer_Tick);<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// &lt;summary&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// This event handler reduce the amplitude and apply a new
<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// OvalWateryEffect on each tick.<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// &lt;/summary&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp;void _timer_Tick(object sender, EventArgs e)<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;if (this._effect.Amplitude &gt; 0.0)<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;this._effect.Amplitude -= 0.05;
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;else<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;this._timer.Stop();<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// &lt;summary&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// This event handler get the current mouse position, assign it to a
<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// private field and start the timer to apply new OvalWateryEffect.<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// &lt;/summary&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp;private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;// Convert the mouse position from control coordinates to texture coordinates as required by the PixelShader<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;this._effect.Center = new Point(e.GetPosition(this.ImageWithPixelShader).X /<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;this.ImageWithPixelShader.ActualWidth, e.GetPosition(<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;this.ImageWithPixelShader).Y / this.ImageWithPixelShader.ActualHeight);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;this._effect.Amplitude= 0.5;<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;_timer.Start();<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp;}<br>
<br>
Step3. Add a new class OvalWateryEffect after the MainPage class:<br>
<br>
&nbsp;&nbsp;&nbsp;&nbsp; /// &lt;summary&gt;<br>
&nbsp; &nbsp;/// OvalWateryEffect class is a custom ShaderEffect class.<br>
&nbsp; &nbsp;/// &lt;/summary&gt;<br>
&nbsp; &nbsp;public class OvalWateryEffect : ShaderEffect<br>
&nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// &lt;summary&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// The following two DependencyProperties are the keys of this custom ShaderEffect.<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// They create a bridge between managed code and HLSL(High Level Shader Language).<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// The PixelShaderConstantCallback will be triggered when the propery get changed.<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// The parameter of the callback represents the register.<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// For instance, here the 1 in PixelShaderConstantCallback(1) represents C1 of the<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// following HLSL code. In another word, by changing<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// the Amplitude property we assign the changed value to the amplitude variable of the<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// following HLSL code:<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// <br>
&nbsp; &nbsp; &nbsp; &nbsp;/// sampler2D input : register(S0);<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// float2 center:register(C0);<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// float amplitude:register(C1);<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// float4 main(float2 uv : TEXCOORD) : COLOR<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// {<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// if(pow((uv.x-center.x),2)&#43;pow((uv.y-center.y),2)&lt;0.15)<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// {<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// uv.y = uv.y &nbsp;&#43; (sin(uv.y*100)*0.1*amplitude);<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// }<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// return tex2D( input , uv.xy);<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// }<br>
&nbsp; &nbsp; &nbsp; &nbsp;/// &lt;/summary&gt;<br>
&nbsp; &nbsp; &nbsp; &nbsp;public static readonly DependencyProperty AmplitudeProperty =
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;DependencyProperty.Register(&quot;Amplitude&quot;, typeof(double), typeof(OvalWateryEffect),
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;new PropertyMetadata(0.1, ShaderEffect.PixelShaderConstantCallback(1)));<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;public static readonly DependencyProperty CenterProperty =
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;DependencyProperty.Register(&quot;Center&quot;, typeof(Point), typeof(OvalWateryEffect),
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;new PropertyMetadata(new Point(0.5, 0.5), ShaderEffect.PixelShaderConstantCallback(0)));<br>
&nbsp; &nbsp; &nbsp; &nbsp;<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;public OvalWateryEffect(Uri uri)<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Uri u = uri;<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;PixelShader psCustom = new PixelShader();<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;psCustom.UriSource = u;<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;PixelShader = psCustom;<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;base.UpdateShaderValue(CenterProperty);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;base.UpdateShaderValue(AmplitudeProperty);<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;public double Amplitude<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;get<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;return (double)base.GetValue(AmplitudeProperty);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;set<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;base.SetValue(AmplitudeProperty, value);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
<br>
&nbsp; &nbsp; &nbsp; &nbsp;public Point Center<br>
&nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;get<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;return (Point)base.GetValue(CenterProperty);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;set<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;{<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;base.SetValue(CenterProperty, value);<br>
&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp; &nbsp; &nbsp;}<br>
&nbsp; &nbsp;}<br>
<br>
</p>
<h3>References:</h3>
<p style="font-family:Courier New"><br>
Programming Guide for HLSL<br>
<a target="_blank" href="http://msdn.microsoft.com/en-us/library/bb509635(VS.85).aspx">http://msdn.microsoft.com/en-us/library/bb509635(VS.85).aspx</a><br>
<br>
Dependency Properties Overview<br>
<a target="_blank" href="http://msdn.microsoft.com/en-us/library/cc221408(VS.95).aspx">http://msdn.microsoft.com/en-us/library/cc221408(VS.95).aspx</a><br>
<br>
Pixel Shader Effects<br>
<a target="_blank" href="http://msdn.microsoft.com/en-us/library/dd901594(VS.95).aspx">http://msdn.microsoft.com/en-us/library/dd901594(VS.95).aspx</a><br>
<br>
<br>
</p>
<hr>
<div><a href="http://go.microsoft.com/?linkid=9759640" style="margin-top:3px"><img src="http://bit.ly/onecodelogo">
</a></div>