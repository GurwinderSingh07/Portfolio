﻿#pragma checksum "C:\Users\14372\source\repos\Final_version\Final_version\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC138022E073CC23452BC610626AAFF75ED7399CDC058F98FF5BB97E3B7EC279"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_version
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.u_input = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.u_input).TextChanged += this.u_input_TextChanged;
                }
                break;
            case 3: // MainPage.xaml line 15
                {
                    this.p_input = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4: // MainPage.xaml line 18
                {
                    this.male = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 5: // MainPage.xaml line 19
                {
                    this.female = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 6: // MainPage.xaml line 20
                {
                    this.cd = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 7: // MainPage.xaml line 21
                {
                    this.pp = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 8: // MainPage.xaml line 22
                {
                    this.nb = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 9: // MainPage.xaml line 23
                {
                    this.check = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 10: // MainPage.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Button_Click;
                }
                break;
            case 11: // MainPage.xaml line 26
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.Button_Click_1;
                }
                break;
            case 12: // MainPage.xaml line 27
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.Button_Click_2;
                }
                break;
            case 13: // MainPage.xaml line 28
                {
                    this.show_password = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.show_password).Click += this.show_password_Click;
                }
                break;
            case 14: // MainPage.xaml line 29
                {
                    this.s_p_box = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

