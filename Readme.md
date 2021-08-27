<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E434)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication12/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication12/Form1.vb))
* [Program.cs](./CS/WindowsApplication12/Program.cs) (VB: [Program.vb](./VB/WindowsApplication12/Program.vb))
<!-- default file list end -->
# How to provide a lookup in a grid column (the LookUpEdit in-place editor)


<p>This is a basic sample to illustrate how to tune a grid column to provide lookup cells. To specify an in-place editor for a column, create a specific repository item (in our scenario it's a RepositoryItemLookUpEdit item), add it to the grid's internal or external repository and then assign it to a column via the GridColumn.ColumnEdit property. <br />
Then, configure the lookup's  DisplayMember and ValueMember properties. If necessary, populate the Columns collection with the columns you need.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/A1023">Text disappears from a LookUp editor after focusing another grid column</a></p>

<br/>


