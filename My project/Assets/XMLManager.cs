using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEditor;
using TMPro;
public class XMLManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text text;
    public TMP_Text textConsole;
    private float heightFloat;
    void Start()
    {
    }

    void Update()
    {
    }

    public void SaveXML()
    {
        SaveFunction();
    }

    public void LoadXML()
    {
        LoadFunction();
    }

    public void ShareXML()
    {
        ShareFunction();
    }

    void ShareFunction()
    {
        text.text = inputField.text;
    }

    void SaveFunction()
    {
        string guid = AssetDatabase.CreateFolder("Assets", "XMLFolder");
        string newFolderFilePath = AssetDatabase.GUIDToAssetPath(guid);

        string path = Application.dataPath + "/XML Folder/BuildingXML.xml";

        File.WriteAllText(path, inputField.text);
        Debug.Log("SaveXML");
    }

    void LoadFunction()
    {
        XmlDocument xdoc = new XmlDocument();
        xdoc.Load(@"C:\Users\josep.pujol\Desktop\My project\Assets\XMLFolder\BuildingXML.xml");
        XmlNodeList nodes = xdoc.SelectNodes("//Building/Floor");
        Debug.Log(nodes.Count);
        foreach(XmlNode node in nodes)
        {
            XmlNode height = node.SelectSingleNode("Height");

            if (height != null)
            {
            }
                Debug.Log(height.InnerText);

            XmlNode slab = node.SelectSingleNode("Slab");

        }
        inputField.text = xdoc.InnerXml;

        Debug.Log("LoadXML");
        Debug.Log(xdoc.InnerText);
        Debug.Log(xdoc.InnerXml);
    }
}
