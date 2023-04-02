﻿using System;
using System.Threading;
using System.Runtime.InteropServices;
using Kompas6API5;
using Kompas6Constants3D;

namespace StoolPlugin.Model.Kompas
{
    /// <summary>
    /// Класс для подключения к Компас-3D
    /// </summary>
    public class KompasConnector
    {
        /// <summary>
        /// Интерфейс работы с API Компас-3D
        /// </summary>
        public KompasObject KsObject { get; }

        /// <summary>
        /// Интерфейс компонента Компаса-3D
        /// </summary>
        public ksPart Part { get; set; }

        /// <summary>
        /// Конструктор класса <see cref="KompasConnector"/>
        /// </summary>
        public KompasConnector()
        {
            var progId = "KOMPAS.Application.5";
            try
            {
                KsObject = (KompasObject)Marshal.GetActiveObject(progId);
            }
            catch(COMException)
            {
                KsObject = (KompasObject)Activator.
                    CreateInstance(Type.GetTypeFromProgID(progId));
                Thread.Sleep(300);
            }
            var ksDoc = KsObject.Document3D();
            ksDoc.Create(false, true);
            Part = ksDoc.GetPart((short)Part_Type.pTop_Part);
            KsObject.Visible = true;
            KsObject.ActivateControllerAPI();
        }
    }
}
