namespace FrambosEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Dynamic;
using System.IO;

public class Frambos {
    static GraphicsDeviceManager graphicsDevice;
    /// <summary>
    /// Logs a message to the console.
    /// </summary>
    /// <param name="message"></param>
    public static void log(string message) => Console.WriteLine(message);

    public static void setGraphicsDevice(GraphicsDeviceManager device) => graphicsDevice ??= device;

    public static Texture2D loadTexture(string path) {
        using FileStream stream = File.OpenRead(path);
        return Texture2D.FromStream(_graphicsDevice, stream);
    }
}