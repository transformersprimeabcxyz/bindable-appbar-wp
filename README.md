# Bindable AppBar - Windows Phone
A big problem when choosing to develop with MVVM in Windows Phone is that the native Application Bar is not bindable, so we can't get/set attributes or commands.
So, the following code snippets will show you how to add a bindable AppBar in Windows phone 8 using MVVM Light Toolkit.

<h2>Background</h2>
<ul>
  <li>Windows Phone</li>
  <li>MVVM</li>
  <li>Nuget Packages</li>
</ul>

<h2>Using the code</h2>
Thanks to the CodePlex open source project "<a target="_blank" href="http://bindableapplicationb.codeplex.com/">Bindable Application Bar</a>", we can get the control that will help us achieving our goal.
P.S : There are many solutions like the Bindable AppBar Appliation project, but I choose this one beacause I think it's the easiest one.
Let's add some code!

<h4>1. Adding Nuget Package</h4>
We can add a reference to that project via its <a target="_blank" href="https://www.nuget.org/packages/BindableApplicationBar/">Nuget Package</a>.

<h4>2. Adding Reference</h4>
Then, we add the reference in our View.

<pre>
  <code>
  xmlns:bar="clr-namespace:BindableApplicationBar;assembly=BindableApplicationBar"
  </code>
</pre>

<h4>3. Adding AppBar</h4>
Finally, we add the AppBar control. We can use it the same way as we use the native AppBar.

<h3>That's it! I hope it was helpful.</h3>
