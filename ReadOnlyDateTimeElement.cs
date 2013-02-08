using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreGraphics;

namespace MonoTouch.Dialog {

    public class ReadOnlyDateTimeElement : DateTimeElement 
    {
        public ReadOnlyDateTimeElement(string caption, DateTime date) :  base (caption, date)
        {
        }

        /// <summary>
        /// Override default settings, disable displaying a disclosure icon.
        /// </summary>
        public override UITableViewCell GetCell (UITableView tv)
        {
            var cell = base.GetCell(tv);
            cell.Accessory = UITableViewCellAccessory.None;
            return cell;
        }

        /// <summary>
        /// Override default settings, do nothing when user taps on element.
        /// </summary>
        public override void Selected (DialogViewController dvc, UITableView tableView, NSIndexPath path)
        {
            // do nothing
        }
    }    
}


