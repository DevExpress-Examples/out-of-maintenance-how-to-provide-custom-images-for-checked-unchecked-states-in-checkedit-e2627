<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication28/MainWindow.xaml))

<!-- default file list end -->
# How to provide custom images for checked/unchecked states in CheckEdit

<p>This example illustrates how to provide a custom glyph instead of a standard check box for inplace and standalone CheckEdit controls.</p>

<p>Starting with version 18.2, CheckEdit can display glyphs instead of a check box. To make CheckEdit display custom glyphs, pass the <a href="https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.ImageCheckEditStyleSettings">ImageCheckEditStyleSettings</a> object to the StyleSettings property and use the <a href="https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.CheckEdit.CheckedGlyph">CheckedGlyph</a>, <a href="https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.CheckEdit.IndeterminateGlyph">IndeterminateGlyph</a>, and <a href="https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.CheckEdit.IndeterminateGlyph">UncheckedGlyph</a> properties to specify glyphs for all CheckEdit states.</p>

<br/>
