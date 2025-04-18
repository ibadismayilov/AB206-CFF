using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem;

public interface ICamera
{
    void StartRecording();
    void StopRecording();
}