namespace Domain.Interfaces;

public interface IDamageable
{
    int PvActuels { get; }
    int PvMax { get; }
    bool EstVivant { get; }
    void RecevoirDegats(int degats);
    void Soigner(int soin);
}