//
// Mobius.Utility.SortedDataGridView
//
// Authors:
//    Paul T Anderson (paul.t.anderson at gmail)
//
// (C) 2007 Paul T Anderson
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using System.ComponentModel;
using System.Diagnostics;

namespace ServiceManager.Controls
{
	public class SortedDataGridView : DataGridView
	{
		DataGridComparer _columnSorter;

		public SortedDataGridView()
		{
			_columnSorter = new DataGridComparer(this);
		}

		protected override void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e)
		{
			_columnSorter.SetSortColumn(e.ColumnIndex, ModifierKeys);

			Sort(_columnSorter);

			Columns[e.ColumnIndex].SortMode = DataGridViewColumnSortMode.Programmatic;

			base.OnColumnHeaderMouseClick(e);
		}

		[Category("Behavior")]
		[Description("The maximum number of columns that may be sorted by or 0 for no limit")]
		[DefaultValue(0)]
		[Browsable(true)]
		public int MaxSortColumns
		{
			get { return _columnSorter.MaxSortColumns; }
			set {
				if (value < 0)
					throw new ArgumentOutOfRangeException("MaxSortColumns must be >= 0, set to 0 for no limit");
				_columnSorter.MaxSortColumns = value;
			}
		}

		public string SortOrderDescription
		{
			get { return _columnSorter.SortOrderDescription; }
		}
	}
}
