﻿using System;
using System.Collections;

namespace AmazonPay.Responses
{

    public class ConfirmOrderReferenceResponse : AbstractResponse
    {
        /// <summary>
        /// ConfirmOrderReferenceResponse 
        /// </summary>
        public ConfirmOrderReferenceResponse(string xml)
        {
            SetDictionaryAndErrorResponse(xml);
            if (success)
            {
                ParseDictionaryToVariables(this.dictionary);
            }
        }
    }
}
