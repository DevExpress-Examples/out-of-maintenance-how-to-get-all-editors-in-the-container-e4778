<!-- default file list -->
*Files to look at*:

* [Selector.cs](./CS/App_Code/Selector.cs) (VB: [Selector.vb](./VB/App_Code/Selector.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to get all editors in the container
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4778/)**
<!-- run online end -->


<p>To achieve this, we first create a Selector class, which uses <a href="http://msdn.microsoft.com/en-us/library/ms379564(v=vs.80).aspx"><u>C# Generics</u></a> for more flexibility. The base class is defined via the 

```cs
where T : Control
```

 constraint.</p><p>This class has one public static method. It accepts any type of control and recursively counts the total number of controls in a container specified as a parameter.</p><p><br />
In the markup we have some controls arranged in two panels. We also have an ASPxButton, which starts the counting process and an ASPxPopupControl to show the results.</p>

<br/>


