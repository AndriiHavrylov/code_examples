using PX.Data;

protected void _(Events.FieldUpdated<Order, Order.locationID> e)
{
    if (e.Row == null)
        return;

    int? routeID = FindLocationRoute(e.Row.LocationID);
    e.Cache.SetValueExt<Order.routeID>(e.Row, routeID);
}
