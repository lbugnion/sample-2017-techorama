﻿#pragma checksum "D:\GitHub\Samples\sample-crossplatform-flowers\Flowers.Uwp\DetailsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8F55586304A7B938B0BCAC13EB0F7CF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flowers
{
    partial class DetailsPage : 
        global::Flowers.Helpers.BaseSecondaryView, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.ContentPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Primitives.ToggleButton element2 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 59 "..\..\..\DetailsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)element2).Checked += this.ExpandImageButtonChecked;
                    #line 60 "..\..\..\DetailsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)element2).Unchecked += this.ExpandImageButtonUnchecked;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
