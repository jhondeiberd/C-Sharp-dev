//////////////////////////DICTIONARY

//////////////////////////Functionresult
{
  "Success": true,
  "StartProcess": "2024-02-27T11:03:45.7363249-05:00",
  "Title": {
    "SetTitleDbAsync": {
      "Start": "2/27/2024 11:03:45 AM",
      "End": "2/27/2024 11:03:49 AM"
    },
    "SetConstituentCodeTypeDbAsync": {
      "Start": "2/27/2024 11:03:49 AM",
      "End": "2/27/2024 11:03:49 AM"
    }
  },
  "EndProcess": "2024-02-27T11:03:45.7394638-05:00"
}


//////////////////////////Function
public async Task<dynamic> SetFunctionAsync()
{
  dynamic o = new ExpandoObject();
  o.StartProcess = DateTime.Now;
  o.Title = new Dictionary<string, Dictionary<string, string>>();
  o.EndProcess = DateTime.Now;
  o.DurationProcess = DateTime.Now;

  try
  {
      //Get 1st group
      o.Title["SetTitleDbAsync"] = new Dictionary<string, string>();
      o.Title["SetTitleDbAsync"]["Start"] = DateTime.Now.ToString();
      Collection collection = await GetListAsync(await GetToken().ConfigureAwait(true));
      o.Title["SetTitleDbAsync"]["End"] = DateTime.Now.ToString();

      //Get 2nd group
      o.Title["SetConsTypeDbAsync"] = new Dictionary<string, string>();
      o.Title["SetConsTypeDbAsync"]["Start"] = DateTime.Now.ToString();
      Collection collection = await GetList2Async(await GetToken().ConfigureAwait(true));
      o.Title["SetConsTypeDbAsync"]["End"] = DateTime.Now.ToString();
      .....

      o.EndProcess = DateTime.Now;
      o.DurationProcess = (DateTime.Now - start).ToString(@"hh\:mm\:ss");
      return o;
  }
  catch (Exception e)
  {
      o.DurationProcess = (DateTime.Now - start).ToString(@"hh\:mm\:ss");
      return o;
  }
