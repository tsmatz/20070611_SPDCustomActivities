���̃T���v���̃J�X�^���A�N�e�B�r�e�B�ł́ASharePoint Designer �ɁA�uContoso �l���f�[�^�x�[�X����}�l�[�W�����擾����v �A�N�e�B�r�e�B��ǉ����܂��B
���̃A�N�e�B�r�e�B�ł́A�w�肵�����[�U�̃}�l�[�W��(��i)�� ID �▼�O�A���[���A�h���X�Ȃǂ��擾����Ƃ����T���v���ł����A
�T���v���Ƃ��āA��Ɉȉ��̌��ʂ�Ԃ��Ă��܂��B(�R�[�h��ύX����ɂ́AVisual Studio ���K�v�ł�)

�}�l�[�W���̃A�J�E���g : <�w�肵�����[�U�Ɠ���̃A�J�E���g>
�}�l�[�W���̖��O : �u�f���p�̃{�X�I�v
�}�l�[�W���̃��[���A�h���X : �uDemoManager@example.jp�v

[�K�v��]

SharePoint Server 2007 (MOSS 2007 / WSS 3.0)
Office SharePoint Designer 2007

[�C���X�g�[�����@]

SharePoint �T�[�o��ňȉ������{���܂�

1. bin/Debug ���� CustomActivities.dll �� GAC �ɔz�u
  (dll �� %systemdrive%\Windows\assembly �Ƀh���b�O�A���h�h���b�v���܂�)
2. �t���� Custom.ACTIONS ��

  %programfiles%\common files\microsoft shared\web server extensions\12\TEMPLATE\1041\Workflow\

  �ɃR�s�[���܂�
3. web.config �ɁuAdd to web.config�v�ɋL�ڂ���Ă�����e�� (authorizedType �v�f�̒��̍ŏI�s��) �ǉ����܂�
  (web.config �́A�ʏ�A%systemdrive%\InetPub\wwwroot\wss\VirtualDirectories\<�|�[�g�ԍ�>\ ���ɂ���܂�)

�� �J���҂̕��ŁA�R�[�h��ҏW�E�ăr���h����ɂ́A

Visual Studio 2005 �� Windows Workflow Foundation extension
�܂��� Visual Studio 2008

���g�p���Ă�������

�� �J���҂̕��ŁA�R�[�h��ύX���čĔz�u����ۂɂ́A�ȉ��ɋL�ڂ���Ă��� assembly cache �̃N���A��K�����{���Ă�������
http://blogs.msdn.com/sharepointdesigner/archive/2007/03/27/tip-clearing-the-spd-workflow-assembly-cache.aspx
