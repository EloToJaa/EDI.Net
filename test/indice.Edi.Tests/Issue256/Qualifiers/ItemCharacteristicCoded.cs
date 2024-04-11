using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace indice.Edi.Tests.Issue256.Qualifiers;

/// <summary>
/// Item characteristic, coded
/// </summary>
public class ItemCharacteristicCoded
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator ItemCharacteristicCoded(string s) => new ItemCharacteristicCoded { Code = s };

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
		{ "1", "Certificate of conformity" },
		{ "2", "General product form" },
		{ "3", "Ship to stock" },
		{ "4", "Finish" },
		{ "5", "End use application" },
		{ "8", "Product" },
		{ "9", "Sub-product" },
		{ "10", "Grain direction" },
		{ "11", "Customs specifications" },
		{ "12", "Type and/or process" },
		{ "13", "Quality" },
		{ "14", "Surface condition" },
		{ "15", "Heat treat/anneal" },
		{ "17", "Coating" },
		{ "18", "Surface treatment, chemical" },
		{ "19", "Surface treatment, mechanical" },
		{ "21", "Forming" },
		{ "22", "Edge treatment" },
		{ "23", "Welds/splices" },
		{ "24", "Control item" },
		{ "25", "End treatment" },
		{ "26", "Ship to line" },
		{ "28", "Test sample frequency" },
		{ "30", "Test sample direction" },
		{ "32", "Type of test/inspection" },
		{ "35", "Colour" },
		{ "38", "Grade" },
		{ "43", "Twist" },
		{ "54", "Section profile" },
		{ "56", "Special processing" },
		{ "58", "Winding instructions" },
		{ "59", "Surface protection" },
		{ "61", "New article" },
		{ "62", "Obsolete article" },
		{ "63", "Current article" },
		{ "64", "Revised design" },
		{ "65", "Reinstated article" },
		{ "66", "Current article spares" },
		{ "67", "Balance out article" },
		{ "68", "Initial sample" },
		{ "69", "Field test" },
		{ "70", "Revised article" },
		{ "71", "Refurbished article" },
		{ "72", "Vintage" },
		{ "73", "Beverage age" },
		{ "74", "Beverage brand" },
		{ "75", "Artist" },
		{ "76", "Author" },
		{ "77", "Binding" },
		{ "78", "Edition" },
		{ "79", "Other physical description" },
		{ "80", "Publisher" },
		{ "81", "Title" },
		{ "82", "Series title" },
		{ "83", "Volume title" },
		{ "84", "Composer" },
		{ "85", "Recording medium" },
		{ "86", "Music style" },
		{ "87", "Promotional event" },
		{ "88", "Promotional offer" },
		{ "89", "Alcohol beverage class" },
		{ "90", "Alcohol beverage type" },
		{ "91", "Secondary grape" },
		{ "92", "Primary grape" },
		{ "93", "Beverage category" },
		{ "94", "Beverage flavour" },
		{ "95", "Wine growing region" },
		{ "96", "Wine fruit" },
		{ "97", "Beverage container characteristics" },
		{ "98", "Size" },
		{ "100", "Project subject" },
		{ "101", "Test panel type" },
		{ "102", "Anatomical origin of sample" },
		{ "103", "Type of sample" },
		{ "104", "Shelf-life code" },
		{ "105", "Limiting operation" },
		{ "106", "Temper" },
		{ "107", "Filament" },
		{ "108", "Denier" },
		{ "109", "Fibre" },
		{ "110", "Lustre" },
		{ "111", "Shade" },
		{ "112", "Tint" },
		{ "113", "Fibre tow" },
		{ "114", "Alloy" },
		{ "115", "Machine run" },
		{ "116", "Corrosion resistance" },
		{ "117", "Visual" },
		{ "118", "Electrical" },
		{ "119", "Functional performance" },
		{ "120", "Chemistry" },
		{ "121", "Physical" },
		{ "122", "Magnetic" },
		{ "123", "Mechanical" },
		{ "124", "Metallographic" },
		{ "125", "Dye lot" },
		{ "126", "Pattern" },
		{ "127", "Appearance" },
		{ "128", "Dispersion" },
		{ "129", "Fluid" },
		{ "130", "Flow" },
		{ "131", "Moisture" },
		{ "132", "Fabric" },
		{ "133", "Shipping unit component" },
		{ "134", "Manufacturing method" },
		{ "135", "Engine" },
		{ "136", "Transmission" },
		{ "137", "Controlled substance class 3 (narcotic)" },
		{ "138", "Controlled substance class 3N (non-narcotic)" },
		{ "139", "Collateral" },
		{ "140", "Chassis" },
		{ "141", "Compliance method" },
		{ "142", "Pipe coupling" },
		{ "143", "Drug efficacy" },
		{ "144", "Dosage form" },
		{ "145", "Dimensional" },
		{ "146", "Fold configuration" },
		{ "147", "Fuel" },
		{ "149", "Hydraulics" },
		{ "150", "Coordinates" },
		{ "151", "Options" },
		{ "152", "Non-prescription drug" },
		{ "153", "Prescription drug" },
		{ "154", "Source" },
		{ "155", "Therapeutic class" },
		{ "156", "Therapeutic equivalency" },
		{ "157", "Filter" },
		{ "158", "Trim" },
		{ "159", "Waste" },
		{ "160", "Bottomhole location method" },
		{ "161", "Bottomhole pressure method" },
		{ "162", "Common chemical name" },
		{ "163", "Chemical family name" },
		{ "164", "Casing or liner type" },
		{ "165", "Well direction" },
		{ "166", "Electronic field" },
		{ "167", "Formula" },
		{ "168", "Ingredient" },
		{ "169", "Market segment" },
		{ "170", "Odour" },
		{ "171", "Physical form" },
		{ "172", "Well perforation continuity" },
		{ "173", "Well perforation interval" },
		{ "174", "Pipeline stream" },
		{ "175", "Surface location method" },
		{ "176", "Threshold" },
		{ "177", "Well classification" },
		{ "178", "Well test type" },
		{ "179", "Major grade" },
		{ "180", "Specification" },
		{ "181", "Test sample location - ends" },
		{ "182", "Product life cycle" },
		{ "183", "Storage and display" },
		{ "184", "Density" },
		{ "185", "Print orientation" },
		{ "186", "Solubility" },
	};
}