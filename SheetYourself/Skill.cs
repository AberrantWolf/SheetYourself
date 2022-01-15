namespace SheetYourself;

internal class Skill : ViewModelBase
{
    public string Name
    {
        get => Properties.Get("New Skill");
        set => Properties.Set(value);
    }

    public override string ToString() => Name;
}
