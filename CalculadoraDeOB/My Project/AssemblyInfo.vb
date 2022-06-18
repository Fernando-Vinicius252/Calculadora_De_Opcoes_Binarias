Imports System
Imports System.Globalization
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.InteropServices
Imports System.Windows

' As informações gerais sobre um assembly são controladas por
' conjunto de atributos. Altere estes valores de atributo para modificar as informações
' associada a um assembly.

' Revise os valores dos atributos do assembly

<Assembly: AssemblyTitle("CalculadoraDeOB")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("CalculadoraDeOB")>
<Assembly: AssemblyCopyright("Copyright ©  2022")>
<Assembly: AssemblyTrademark("")>
<Assembly: ComVisible(false)>

'Para começar a compilar aplicativos localizáveis, configure
'<UICulture>CultureYouAreCodingWith</UICulture> no seu arquivo .vbproj
'dentro de um <Grupo de Propriedade>.  Por exemplo, se você está usando o idioma inglês
'nos seus arquivos de origem, configure a <UICulture> para "en-US". Depois, descomente o
'atributo NeutralResourceLanguage abaixo.  Atualize o "en-US" na linha
'abaixo para coincidir a configuração de UICulture no arquivo de projeto.

'<Assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)>


'O atributo ThemeInfo descreve onde encontrar temas específicos e dicionários de recursos genéricos.
'1º parâmetro: onde dicionários de recursos de tema específico se encontram
'(usado se algum recurso não for encontrado na página,
' ou dicionários de recursos do aplicativo)

'2º parâmetro: onde os dicionários de recursos genéricos se encontram
'(usado se algum recurso não for encontrado na página,
'aplicativo e qualquer dicionário de recursos de tema específico)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>



'O GUID a seguir será destinado à ID de typelib se este projeto for exposto para COM
<Assembly: Guid("ee5943ec-c330-491d-832c-29313404b4e1")>

' As informações da versão de um assembly consistem nos quatro valores a seguir:
'
'      Versão Principal
'      Versão Secundária 
'      Número da Versão
'      Revisão
'
' É possível especificar todos os valores ou usar como padrão os Números de Build e da Revisão
' usando o "*" como mostrado abaixo:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
