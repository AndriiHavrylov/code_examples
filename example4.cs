using PX.Data;
using PX.Objects.FS;

private void UpdateOrderContact(PXCache contactCache, string newEmail)
{
    FSContact contact = GetOrderContact();

    contactCache.SetValueExt<FSContact.overrideContact>(contact, true);
    ApplyEmail(contact, newEmail);
}
