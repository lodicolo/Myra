/* Generated by MyraPad at 27.02.2020 21:06:28 */
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;

#if !XENKO
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#else
using Xenko.Core.Mathematics;
#endif

namespace MyraPad.UI
{
	partial class ExportOptionsDialog: Dialog
	{
		private void BuildUI()
		{
			var label1 = new Label();
			label1.Text = "Class Name:";
			label1.GridRow = 1;

			_textClassName = new TextBox();
			_textClassName.GridColumn = 1;
			_textClassName.GridRow = 1;
			_textClassName.Id = "_textClassName";

			var label2 = new Label();
			label2.Text = "Output Path:";
			label2.GridRow = 2;

			_textOutputPath = new TextBox();
			_textOutputPath.GridColumn = 1;
			_textOutputPath.GridRow = 2;
			_textOutputPath.Id = "_textOutputPath";

			_buttonChangeOutputPath = new TextButton();
			_buttonChangeOutputPath.Text = "Change...";
			_buttonChangeOutputPath.GridColumn = 2;
			_buttonChangeOutputPath.GridRow = 2;
			_buttonChangeOutputPath.Id = "_buttonChangeOutputPath";

			var label3 = new Label();
			label3.Text = "Namespace:";

			_textNamespace = new TextBox();
			_textNamespace.GridColumn = 1;
			_textNamespace.Id = "_textNamespace";

			Root = new Grid();
			Root.ColumnSpacing = 8;
			Root.RowSpacing = 8;
			Root.DefaultRowProportion = new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			};
			Root.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Root.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			Root.ColumnsProportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Root.Width = 800;
			Root.Id = "Root";
			Root.Widgets.Add(label1);
			Root.Widgets.Add(_textClassName);
			Root.Widgets.Add(label2);
			Root.Widgets.Add(_textOutputPath);
			Root.Widgets.Add(_buttonChangeOutputPath);
			Root.Widgets.Add(label3);
			Root.Widgets.Add(_textNamespace);

			
			Title = "Export";
			Left = 76;
			Top = 150;
			Content = Root;
		}

		
		public TextBox _textClassName;
		public TextBox _textOutputPath;
		public TextButton _buttonChangeOutputPath;
		public TextBox _textNamespace;
		public Grid Root;
	}
}