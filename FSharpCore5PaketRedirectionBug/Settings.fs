namespace FSharpCore5PaketRedirectionBug

open FSharp.Configuration

type SettingsType = YamlConfig<YamlText="foo: 1", ReadOnly=true>

module Settings =
    let Default = SettingsType()
