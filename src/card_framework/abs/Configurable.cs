using System;
using System.Collections.Generic;

namespace src.card_framework.abs
{
    public interface Configurable {
        public abstract Dictionary<String, String> Config();

        public abstract void Config(Dictionary<String, String> config);
    }
}