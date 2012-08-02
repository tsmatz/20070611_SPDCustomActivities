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
    // ���� Activity �N���X����������ꍇ�́A
    // Activity ���p������ Execute ���\�b�h���������܂�
    // (����́ASequenceActivity ���p�����Ă���̂Ń��[�N�t���[���l�X�g�ł��܂�)

	public partial class MyFindManager: SequenceActivity
	{
		public MyFindManager()
		{
			InitializeComponent();
		}

        #region ���L�����v���p�e�B

        public static DependencyProperty ManagerAccountNameProperty = System.Workflow.ComponentModel.DependencyProperty.Register("ManagerAccountName", typeof(string), typeof(MyFindManager));

        [ValidationOption(ValidationOption.Optional)]
        [Description("�Ǘ��҂̃A�J�E���g�����i�[����ɂ́A�ϐ�����͂��܂�")]
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
        [Description("�Ǘ��҂̕\�������i�[����ɂ́A�ϐ�����͂��܂��B")]
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
        [Description("�Ǘ��҂̓d�q���[�� �A�h���X���i�[����ɂ́A�ϐ�����͂��܂�")]
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
        [Description("�A�N�e�B�r�e�B�̌��ʂ��i�[����ɂ́A�ϐ�����͂��܂�")]
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
        [Description("�A�N�e�B�r�e�B�̐��ۂ��i�[����ɂ́A�ϐ�����͂��܂��B")]
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
        [Description("�Ǘ��҂��������郆�[�U�[�̃A�J�E���g������͂��܂��B")]
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

            // �l���f�[�^�x�[�X������ !
            // �����ł́A���͂��ꂽ�A�J�E���g�{�l�����̂܂ܕԂ��܂�....
            // (�����̊J���ł́AActive Directory ����̌����Ȃǂ������Ȃ��Ă�������)
            ///////
            ManagerAccountName = AccountName;
            ManagerDisplayName = "�f���p�̃{�X�I";
            ManagerEmailAddress = "DemoManager@example.jp";
            Outcome = "�Ǘ��҂𐳏�Ɏ擾���܂����B";

            SearchSuccessful = true;
        }

	}
}
