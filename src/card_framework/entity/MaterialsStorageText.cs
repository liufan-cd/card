using System.Collections.Generic;
using src.card_framework.abs;
using src.card_framework.model;

namespace src.card_framework.entity
{
    public class MaterialsStorageText : ComponentContainer
    {
        public MaterialsStorageText () {
            this.SetName("materials_storage_text");
            Dictionary<string, string> config = GetConfig();
            this.Model = new MaterialsStorageTextModel(config);
            this.View = Model.GenerateView();
        }

        public override void BeforeChildrenStart()
        {
        
        }
    }
}