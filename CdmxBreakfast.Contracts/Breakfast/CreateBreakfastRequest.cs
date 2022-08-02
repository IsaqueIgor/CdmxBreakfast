namespace CdmxBreakfast.Contracts.Breakfast;

public record CreateBreakfastRequest(
   string Name,
   string Description,
   string City,
   DateTime StartDateTime,
   DateTime EndDateTime,
   List<string> Savory,
   List<string> Sweet
);