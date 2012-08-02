using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace CustomActivities
{
    // 基底の Activity クラスを実装する場合は、
    // Activity を継承して Execute メソッドを実装します
    // (今回は、SequenceActivity を継承しているのでワークフローをネストできます)

	public partial class MyFindManager: SequenceActivity
	{
		public MyFindManager()
		{
			InitializeComponent();
		}

        #region 共有されるプロパティ

        public static DependencyProperty ManagerAccountNameProperty = System.Workflow.ComponentModel.DependencyProperty.Register("ManagerAccountName", typeof(string), typeof(MyFindManager));

        [ValidationOption(ValidationOption.Optional)]
        [Description("管理者のアカウント名を格納するには、変数を入力します")]
        [Category("ReturnValues")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ManagerAccountName
        {
            get
            {
                return ((string)(base.GetValue(MyFindManager.ManagerAccountNameProperty)));
            }
            set
            {
                base.SetValue(MyFindManager.ManagerAccountNameProperty, value);
            }
        }

        public static DependencyProperty ManagerDisplayNameProperty = System.Workflow.ComponentModel.DependencyProperty.Register("ManagerDisplayName", typeof(string), typeof(MyFindManager));

        [ValidationOption(ValidationOption.Optional)]
        [Description("管理者の表示名を格納するには、変数を入力します。")]
        [Category("ReturnValues")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ManagerDisplayName
        {
            get
            {
                return ((string)(base.GetValue(MyFindManager.ManagerDisplayNameProperty)));
            }
            set
            {
                base.SetValue(MyFindManager.ManagerDisplayNameProperty, value);
            }
        }
        public static DependencyProperty ManagerEmailAddressProperty = System.Workflow.ComponentModel.DependencyProperty.Register("ManagerEmailAddress", typeof(string), typeof(MyFindManager));

        [ValidationOption(ValidationOption.Optional)]
        [Description("管理者の電子メール アドレスを格納するには、変数を入力します")]
        [Category("ReturnValues")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ManagerEmailAddress
        {
            get
            {
                return ((string)(base.GetValue(MyFindManager.ManagerEmailAddressProperty)));
            }
            set
            {
                base.SetValue(MyFindManager.ManagerEmailAddressProperty, value);
            }
        }

        public static DependencyProperty OutcomeProperty = System.Workflow.ComponentModel.DependencyProperty.Register("Outcome", typeof(string), typeof(MyFindManager));

        [ValidationOption(ValidationOption.Optional)]
        [Description("アクティビティの結果を格納するには、変数を入力します")]
        [Category("ReturnValues")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Outcome
        {
            get
            {
                return ((string)(base.GetValue(MyFindManager.OutcomeProperty)));
            }
            set
            {
                base.SetValue(MyFindManager.OutcomeProperty, value);
            }
        }

        public static DependencyProperty SearchSuccessfulProperty = System.Workflow.ComponentModel.DependencyProperty.Register("SearchSuccessful", typeof(bool), typeof(MyFindManager));

        [ValidationOption(ValidationOption.Optional)]
        [Description("アクティビティの成否を格納するには、変数を入力します。")]
        [Category("ReturnValues")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool SearchSuccessful
        {
            get
            {
                return ((bool)(base.GetValue(MyFindManager.SearchSuccessfulProperty)));
            }
            set
            {
                base.SetValue(MyFindManager.SearchSuccessfulProperty, value);
            }
        }

        public static DependencyProperty AccountNameProperty = System.Workflow.ComponentModel.DependencyProperty.Register("AccountName", typeof(string), typeof(MyFindManager));

        [ValidationOption(ValidationOption.Required)]
        [Description("管理者を検索するユーザーのアカウント名を入力します。")]
        [Category("InputValues")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string AccountName
        {
            get
            {
                return ((string)(base.GetValue(MyFindManager.AccountNameProperty)));
            }
            set
            {
                base.SetValue(MyFindManager.AccountNameProperty, value);
            }
        }

        #endregion

        private void SetManagerFields(object sender, EventArgs e)
        {
            SearchSuccessful = false;

            // 人事データベースを検索 !
            // ここでは、入力されたアカウント本人をそのまま返します....
            // (現実の開発では、Active Directory からの検索などをおこなってください)
            ///////
            ManagerAccountName = AccountName;
            ManagerDisplayName = "デモ用のボス！";
            ManagerEmailAddress = "DemoManager@example.jp";
            Outcome = "管理者を正常に取得しました。";

            SearchSuccessful = true;
        }

	}
}
