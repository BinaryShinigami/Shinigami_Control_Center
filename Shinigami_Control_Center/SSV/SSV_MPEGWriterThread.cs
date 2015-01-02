using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge.Video;
using AForge.Video.FFMPEG;
using System.Threading;

namespace Shinigami_Security_Viewer.SSV
{
    class SSV_MPEGWriterThread
    {
        private List<Bitmap> m_Frames;
        private VideoFileWriter m_MpegWriter;
        public Mutex m_Mutex;
        private Boolean m_ThreadRunning;

        public SSV_MPEGWriterThread(String filename)
        {
            m_Frames = new List<Bitmap>();
            m_MpegWriter = new VideoFileWriter();
            m_Mutex = new Mutex();
            m_ThreadRunning = false;

            m_MpegWriter.Open(filename, 1280, 720, 25, VideoCodec.MPEG4,(2500 * 1024)); //2500*1024 = 2500 Kbps which is about 19Mb per minute but should be good quality
        }

        public void stopThread()
        {
            m_ThreadRunning = false;
            writeFrames();
            m_MpegWriter.Close();
            m_MpegWriter.Dispose();
            clearFrames();
        }

        public void appendFrame(Bitmap frame)
        {
            m_Mutex.WaitOne();
            m_Frames.Add(frame);
            m_Mutex.ReleaseMutex();
        }

        public void clearFrames()
        {
            m_Frames.Clear();
        }

        public void writeFrames()
        {
            if ((m_MpegWriter.IsOpen) && (m_Frames.Count > 10))
            {
                m_Mutex.WaitOne();
                foreach(Bitmap frame in m_Frames)
                {
                    m_MpegWriter.WriteVideoFrame(frame);
                }
                clearFrames();
                m_Mutex.ReleaseMutex();
            }
        }

        public void frameWriterThreadFunc() 
        {
            m_ThreadRunning = true;
            while (m_ThreadRunning)
            {
                writeFrames();
            }
        }
    }
}
