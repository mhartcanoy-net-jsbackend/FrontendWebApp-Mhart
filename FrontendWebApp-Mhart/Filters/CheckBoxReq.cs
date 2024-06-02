using System.ComponentModel.DataAnnotations;

namespace FrontendWebApp_Mhart.Filters;

public class CheckBoxReq : ValidationAttribute
{
	public override bool IsValid(object? value) => value is bool b && b;
}

