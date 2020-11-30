# 概要

単一EXEファイル作成サンプル

# 詳細

1. Constra.Fodyを使用。（内部でILMergeを呼んでいる）
2. デバッグができるよう追加設定

修正前：
```
  <ItemGroup>
    <Reference Include="Costura, Version=4.1.0.0, Culture=neutral, PublicKeyToken=9919ef960d84173d, processorArchitecture=MSIL">
      <HintPath>..\packages\Costura.Fody.4.1.0\lib\net40\Costura.dll</HintPath>
    </Reference>
...
```

修正後：

```C#
  <ItemGroup Condition="$(TargetFramework.StartsWith('net4')) AND '$(Configuration)' == 'Release'">
    <Reference Include="Costura, Version=4.1.0.0, Culture=neutral, PublicKeyToken=9919ef960d84173d, processorArchitecture=MSIL">
      <HintPath>..\packages\Costura.Fody.4.1.0\lib\net40\Costura.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
```