using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace indice.Edi.Tests.Issue256.Qualifiers;

/// <summary>
/// Size qualifier
/// </summary>
public class SizeQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator SizeQualifier(string s) => new SizeQualifier { Code = s };

	/// <summary>
	/// Code of the value
	/// </summary>
	public string? Code { get; set; }

	/// <summary>
	/// Value converted from code
	/// </summary>
	public string? Value => Code is null ? null : (Qualifiers.ContainsKey(Code) ? Qualifiers[Code] : null);

	/// <summary>
	/// All possible values
	/// </summary>
	[JsonIgnore]
	public Dictionary<string, string> Qualifiers => new Dictionary<string, string>
	{
		{ "1", "Population size" },
		{ "2", "Sample size" },
		{ "3", "Subgroup size" },
	};
}