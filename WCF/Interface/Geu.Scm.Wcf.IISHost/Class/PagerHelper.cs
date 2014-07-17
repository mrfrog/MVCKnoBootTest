using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wcf.IISHost.Class
{
    public static class PagerHelper
    {
        public static void ReadOutput<TOutput, TOutputItem>(System.Collections.IList inputList, Interface.IInputPaged pageInfo, TOutput output) where TOutput : Interface.IOutputPaged<TOutputItem>
        {
            if (pageInfo.PageSize.HasValue)
            {
                for (int i = pageInfo.PageIndex * pageInfo.PageSize.GetValueOrDefault(); i < pageInfo.PageIndex * pageInfo.PageSize.GetValueOrDefault() + pageInfo.PageSize.GetValueOrDefault(); i++)
                {
                  //  if (i < inputList.Count)
                       // output.Items.Add(Automapper.Helper.Map<TOutputItem>(inputList[i]));
                }
                output.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(inputList.Count) / pageInfo.PageSize.GetValueOrDefault()));
            }
            else
            {
                //foreach (var oi in inputList)
                //  output.Items.Add(Automapper.Helper.Map<TOutputItem>(oi));
                //output.TotalPages = 1;
            }

            output.PageSize = pageInfo.PageSize;
            output.PageIndex = pageInfo.PageIndex;
            output.TotalResults = inputList.Count;
        }

    }
}