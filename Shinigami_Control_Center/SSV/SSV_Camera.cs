﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge;
using AForge.Video;
using AForge.Video.FFMPEG;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Shinigami_Security_Viewer.SSV
{
    class SSV_Camera
    {

        private SSV_CameraPanel m_CameraPanel;
        private Bitmap m_LastFrame;
        private String m_CameraURL;
        private String m_CameraUsername;
        private String m_CameraPassword;
        private MJPEGStream m_CameraStream;
        private SSV_MPEGWriterThread m_WriterThread;
        private Thread m_Thread;

        public SSV_Camera(String cameraURL, String cameraUsername = "", String cameraPassword = "")
        {
            m_CameraPanel = new SSV_CameraPanel();
            //m_CameraPanel.AutoSize = true;

            m_CameraStream = new MJPEGStream(cameraURL);
            
            if ((cameraUsername.Length > 0) || (cameraPassword.Length > 0))
            {
                m_CameraStream.Login = cameraUsername;
                m_CameraStream.Password = cameraPassword;
            }

            m_CameraStream.NewFrame += new NewFrameEventHandler(cameraNewFrameEvent);

        }

        private void cameraNewFrameEvent(object source, NewFrameEventArgs eventArgs)
        {
            this.m_LastFrame = new Bitmap(eventArgs.Frame, m_CameraPanel.Size);
            m_CameraPanel.setImage(m_LastFrame);
        }

        public SSV_CameraPanel getCameraPanel()
        {
            return this.m_CameraPanel;
        }

        public void startCameraCapture()
        {
            m_CameraStream.Start();
        }

        public void stopCameraCapture()
        {
            m_CameraStream.Stop();
        }

        public void startVideoOutput(string filename)
        {
            m_WriterThread = new SSV_MPEGWriterThread(filename);

            m_Thread = new Thread(new ThreadStart(m_WriterThread.frameWriterThreadFunc));
            m_Thread.Start();

            m_CameraStream.NewFrame += new NewFrameEventHandler(storeFrameForFileEvent);

        }

        private void storeFrameForFileEvent(object source, NewFrameEventArgs eventArgs)
        {
            m_WriterThread.appendFrame(new Bitmap(eventArgs.Frame));
        }

        public void stopVideoOutput()
        {
            m_WriterThread.stopThread();   
        }

    }
}