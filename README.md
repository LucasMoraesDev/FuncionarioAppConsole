# Aplicativo do Console - Gravador de Funcionários em JSON

Este projeto é um exemplo de um aplicativo do console em C# que permite ao usuário inserir os dados de um funcionário e gravar essas informações em um arquivo JSON na máquina local.

## Funcionalidade

- O aplicativo solicita ao usuário que insira os seguintes dados do funcionário:

```csharp
private Guid _id;
private string _nome;
private string _cpf;
private string _matricula;
private DateTime _dataAdmissao;
private string _cargo;
private decimal _salario;
