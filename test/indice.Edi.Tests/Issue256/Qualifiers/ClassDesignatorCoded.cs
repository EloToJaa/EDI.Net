using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace indice.Edi.Tests.Issue256.Qualifiers;

/// <summary>
/// Class designator, coded
/// </summary>
public class ClassDesignatorCoded
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator ClassDesignatorCoded(string s) => new ClassDesignatorCoded { Code = s };

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
		{ "1", "EDIFACT service data element code list" },
		{ "2", "WP.4 international code list" },
		{ "3", "Non WP.4 code list" },
		{ "4", "EDIFACT user data element code list" },
	};
}