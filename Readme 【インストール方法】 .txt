このサンプルのカスタムアクティビティでは、SharePoint Designer に、「Contoso 人事データベースからマネージャを取得する」 アクティビティを追加します。
このアクティビティでは、指定したユーザのマネージャ(上司)の ID や名前、メールアドレスなどを取得するというサンプルですが、
サンプルとして、常に以下の結果を返しています。(コードを変更するには、Visual Studio が必要です)

マネージャのアカウント : <指定したユーザと同一のアカウント>
マネージャの名前 : 「デモ用のボス！」
マネージャのメールアドレス : 「DemoManager@example.jp」

[必要環境]

SharePoint Server 2007 (MOSS 2007 / WSS 3.0)
Office SharePoint Designer 2007

[インストール方法]

SharePoint サーバ上で以下を実施します

1. bin/Debug 下の CustomActivities.dll を GAC に配置
  (dll を %systemdrive%\Windows\assembly にドラッグアンドドロップします)
2. 付属の Custom.ACTIONS を

  %programfiles%\common files\microsoft shared\web server extensions\12\TEMPLATE\1041\Workflow\

  にコピーします
3. web.config に「Add to web.config」に記載されている内容を (authorizedType 要素の中の最終行に) 追加します
  (web.config は、通常、%systemdrive%\InetPub\wwwroot\wss\VirtualDirectories\<ポート番号>\ 下にあります)

※ 開発者の方で、コードを編集・再ビルドするには、

Visual Studio 2005 と Windows Workflow Foundation extension
または Visual Studio 2008

を使用してください

※ 開発者の方で、コードを変更して再配置する際には、以下に記載されている assembly cache のクリアを必ず実施してください
http://blogs.msdn.com/sharepointdesigner/archive/2007/03/27/tip-clearing-the-spd-workflow-assembly-cache.aspx
