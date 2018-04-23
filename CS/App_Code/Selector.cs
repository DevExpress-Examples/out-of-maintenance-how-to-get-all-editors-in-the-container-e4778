using System;
using System.Collections.Generic;
using System.Web.UI;

public class Selector
{
    public static List<T> GetEditorsInContainer<T>(Control container) where T : Control {
        if(container == null)
            throw new ArgumentNullException("Container is not specified.");

        List<T> res = new List<T>();

        GetControls<T>(container, res);

        return res;
    }

    private static void GetControls<T>(Control container, List<T> lst) where T: Control {
        foreach(Control ctrl in container.Controls) {
            if(ctrl.HasControls())
                GetControls<T>(ctrl, lst);

            if(ctrl is T)
                lst.Add((T)ctrl);
        }
    }
}