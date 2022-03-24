﻿using Kompas6API5;
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
        /// Класс параметров стола
        /// </summary>
        private StoolParameters _tableParameters;
        
        /// <summary>
        /// Метод для построения 3D модели
        /// </summary>
        /// <param name="tableParameters">Параметры стола</param>
        /// <param name="legsType">Тип ножек стола</param>
        public void Build(StoolParameters tableParameters)
        {
            _tableParameters = tableParameters;
            _kompasConnector = new KompasConnector();

            CreateTopTable();
            CreateTableLegs();
        }

        /// <summary>
        /// Метод для построения столешницы
        /// </summary>
        private void CreateTopTable() 
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOY);
            var doc2D = (ksDocument2D)sketchDef.BeginEdit();

            var rectangleParam = 
                (ksRectangleParam)_kompasConnector.KsObject.
                GetParamStruct((short)StructType2DEnum.
                    ko_RectangleParam);

            rectangleParam.x = 0;
            rectangleParam.y = 0;
            rectangleParam.ang = 0;
            rectangleParam.height = _tableParameters.
                GetValue(ParameterType.StoolTopWidth);
            rectangleParam.width = _tableParameters.
                GetValue(ParameterType.StoolTopLength);
            rectangleParam.style = 1;
            doc2D.ksRectangle(rectangleParam);
            sketchDef.EndEdit();
            PressOutSketch(sketchDef, _tableParameters.
                GetValue(ParameterType.StoolTopThickness));
        }

        /// <summary>
        /// Метод для построения ножек стола
        /// </summary>
        private void CreateTableLegs()
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOY);
            var doc2D = (ksDocument2D)sketchDef.BeginEdit();

            const double offsetCoordinate = 30.0;
            double legsValue = _tableParameters.
                GetValue(ParameterType.StoolLegsBase);

            // Координаты центров ножек стола
            var x = new double[4];
            var y = new double[4];

            x[0] = offsetCoordinate + (legsValue / 2.0);
            y[0] = offsetCoordinate + (legsValue / 2.0);

            x[1] = _tableParameters.
                       GetValue(ParameterType.StoolTopLength)
                   - (legsValue / 2.0) - offsetCoordinate;
            y[1] = _tableParameters.GetValue(
                    ParameterType.StoolTopWidth) - (legsValue / 2.0)
                                                 - offsetCoordinate;

            x[2] = offsetCoordinate + (legsValue / 2.0);
            y[2] = _tableParameters.GetValue(
                    ParameterType.StoolTopWidth) - (legsValue / 2.0)
                                                 - offsetCoordinate;

            x[3] = _tableParameters.GetValue(
                    ParameterType.StoolTopLength) - (legsValue / 2.0)
                                                  - offsetCoordinate;
            y[3] = (legsValue / 2.0) + offsetCoordinate;

            // Создание квадратного основания ножек
            for (int i = 0; i < x.Length; i++)
            {
                var rectagleParam = (ksRectangleParam)_kompasConnector.
                    KsObject.GetParamStruct((short)StructType2DEnum.
                        ko_RectangleParam);
                rectagleParam.x = x[i] -
                                  (_tableParameters.
                                      GetValue(ParameterType.
                                          StoolLegsBase) / 2.0);
                rectagleParam.y = y[i] -
                                  (_tableParameters.
                                      GetValue(ParameterType.
                                          StoolLegsBase) / 2.0);
                rectagleParam.ang = 0;
                rectagleParam.height = _tableParameters.
                    GetValue(ParameterType.StoolLegsBase);
                rectagleParam.width = _tableParameters.
                    GetValue(ParameterType.StoolLegsBase);
                rectagleParam.style = 1;
                doc2D.ksRectangle(rectagleParam);
            }

            sketchDef.EndEdit();
            PressOutSketch(sketchDef, _tableParameters.
                GetValue(ParameterType.StoolLegsHeight), side: false);
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
            if(type == ksObj3dTypeEnum.o3d_bossExtrusion)
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
            else if(type == ksObj3dTypeEnum.o3d_cutExtrusion)
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
