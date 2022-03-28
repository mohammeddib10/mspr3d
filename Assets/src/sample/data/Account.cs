using System;
using System.Collections.Generic;
using Boomlagoon.JSON;
using Salesforce;

public class Account : SalesforceRecord {

    public const string BASE_QUERY = "SELECT Name, Phone, Fax FROM Account";

    public string name { get; set; }
    public string phone { get; set; }
    public string fax { get; set; }

    public Account() {}

    public Account(string name, string phone, string fax) {
        this.name = name;
        this.phone = phone;
        this.fax = fax;
    }

    public override string getSObjectName() {
        return "Account";
    }

    public override JSONObject toJson() {
        JSONObject record = base.toJson();
        record.Add("Name", name);
        record.Add("Phone", phone);
        record.Add("Fax", fax);
        return record;
    }

    public override void parseFromJson(JSONObject jsonObject) {
        base.parseFromJson(jsonObject);
        name = jsonObject.GetString("Name");
        phone = jsonObject.GetString("Phone");
        fax = jsonObject.GetString("Fax");
    }
}
