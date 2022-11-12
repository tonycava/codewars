static bool Check(object[] obj, object search)
{
    return obj.Select(x => x == search ? true : false).Any();

    foreach (var x in obj)
    {
        if (x.Equals(search)) return true;
    }
    return false;
}