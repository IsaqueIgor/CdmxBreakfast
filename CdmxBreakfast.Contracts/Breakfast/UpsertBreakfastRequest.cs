namespace BuberBreakfast.Contracts.Breakfast;

public record UpsertBreakfastRequest(
   string Name,
   string Description,
   string City,
   DateTime StartDateTime,
   DateTime EndDateTime,
   List<string> Savory,
   List<string> Sweet
);