# �T�v

�P��EXE�t�@�C���쐬�T���v��

# �ڍ�

1. Constra.Fody���g�p�B�i������ILMerge���Ă�ł���j
2. �f�o�b�O���ł���悤�ǉ��ݒ�

�C���O�F
```
  <ItemGroup>
    <Reference Include="Costura, Version=4.1.0.0, Culture=neutral, PublicKeyToken=9919ef960d84173d, processorArchitecture=MSIL">
      <HintPath>..\packages\Costura.Fody.4.1.0\lib\net40\Costura.dll</HintPath>
    </Reference>
...
```

�C����F

```C#
  <ItemGroup Condition="$(TargetFramework.StartsWith('net4')) AND '$(Configuration)' == 'Release'">
    <Reference Include="Costura, Version=4.1.0.0, Culture=neutral, PublicKeyToken=9919ef960d84173d, processorArchitecture=MSIL">
      <HintPath>..\packages\Costura.Fody.4.1.0\lib\net40\Costura.dll</HintPath>
    </Reference>
  </ItemGroup>
  <ItemGroup>
```