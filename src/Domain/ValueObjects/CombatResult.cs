namespace Domain.ValueObjects;

public record CombatResult(
    bool Succes,
    string Message,
    int DegatsInfliges = 0,
    int SoinApplique = 0
);