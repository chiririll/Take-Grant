namespace TakeGrant.Model
{
    public enum Rights : byte
    {
        None = 0,
        Read = 1,
        Write = Read << 1,
        Take = Write << 1,
        Grant = Take << 1,
    }
}
