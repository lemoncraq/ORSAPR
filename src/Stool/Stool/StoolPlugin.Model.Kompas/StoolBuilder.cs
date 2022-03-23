using Kompas6API5;
using Kompas6Constants3D;
using Kompas6Constants;
using StoolPlugin.Model.Parameters;

namespace StoolPlugin.Model.Kompas
{
    /// <summary>
    /// Класс для построения 3D модели
    /// </summary>
    public class StoolBuilder
    {
        /// <summary>
        /// Класс для работы с Компас3D
        /// </summary>
        private KompasConnector _kompasConnector;

        /// <summary>
        /// Класс параметров табурета
        /// </summary>
        private StoolParameters _stoolParameters;

        /// <summary>
        /// Метод для построения 3D модели
        /// </summary>
        /// <param name="stoolParameters">Параметры табурета</param>
        public void Build(StoolParameters stoolParameters)
        {
            _stoolParameters = stoolParameters;
            _kompasConnector = new KompasConnector();

            CreateTopStool();
            CreateStoolLegs();
        }

        /// <summary>
        /// Создание эскиза
        /// </summary>
        /// <param name="planeType"></param>
        /// <returns></returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType)
        {
            // Выбор плоскоти
            var plane = (ksEntity)_kompasConnector.Part.
                GetDefaultEntity((short)planeType);

            // Создание эскиза
            var sketch = (ksEntity)_kompasConnector.Part.
                NewEntity((short)Obj3dType.o3d_sketch);

            // Устанавливаем эскизу рабочую плоскость
            ksSketchDefinition sketchDef = sketch.GetDefinition();
            sketchDef.SetPlane(plane);
            sketch.Create();

            return sketchDef;
        }

        /// <summary>
        /// Метод выдавливания по эскизу
        /// </summary>
        /// <param name="sketchDef">Эскиз</param>
        /// <param name="height">Высота выдавливания</param>
        /// <param name="type">Тип выдавливания</param>
        /// <param name="side">Направление выдавливания</param>
        private void PressOutSketch(ksSketchDefinition sketchDef,
            double height,
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossExtrusion,
            bool side = true)
        {
            var extrusionEntity = (ksEntity)_kompasConnector.
                Part.NewEntity((short)type);
            if (type == ksObj3dTypeEnum.o3d_bossExtrusion)
            {
                var extrusionDef =
                  (ksBossExtrusionDefinition)extrusionEntity.
                      GetDefinition();

                // Параметры выдавливания
                extrusionDef.SetSideParam(side,
                    (short)End_Type.etBlind, height);
                extrusionDef.directionType = side
                    ? (short)Direction_Type.dtNormal
                    : (short)Direction_Type.dtReverse;

                // Эскиз операции выдавливания
                extrusionDef.SetSketch(sketchDef);
            }
            else if (type == ksObj3dTypeEnum.o3d_cutExtrusion)
            {
                var extrusionDef =
                    (ksCutExtrusionDefinition)extrusionEntity.
                        GetDefinition();

                // Параметры выдавливания
                extrusionDef.SetSideParam(side, (short)End_Type.
                    etBlind, height);
                extrusionDef.directionType = side
                    ? (short)Direction_Type.dtNormal
                    : (short)Direction_Type.dtReverse;

                extrusionDef.SetSketch(sketchDef);
            }
            extrusionEntity.Create();
        }
    }
}
