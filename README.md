# 概要

単一EXEファイル作成サンプル

# 詳細

1. NugetでConstra.Fodyを使用。（内部でILMergeを呼んでいる）
2. デバッグができるよう設定。
    * .gitignoreに「FodyWeavers.xml」を追加。
    * 「FodyWeavers_Debug.xml」を追加。
    * 「FodyWeavers_Release.xml」を追加。
        * 「プロジェクト」→「プロパティ」→「ビルドイベント」→「ビルド前イベント」

```
if $(ConfigurationName) == Debug (
xcopy /Y "$(ProjectDir)FodyWeavers_Debug.xml" "$(ProjectDir)FodyWeavers.xml*"
) ELSE (
xcopy /Y "$(ProjectDir)FodyWeavers_Release.xml" "$(ProjectDir)FodyWeavers.xml*"
)
```


