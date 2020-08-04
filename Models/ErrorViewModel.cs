using System;

namespace Final.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public static bool ErrorLogin { get; set; }
        public static bool ErrorAdmin { get; set; }
        public static bool CompletadoAdmin { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
