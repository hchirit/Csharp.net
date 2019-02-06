package test;

import Elements.Camera;
import Elements.PointLight;
import Geometries.Quadrangle;
import Geometries.Triangle;
import org.junit.Test;
import Primitives.Point3D;
import Primitives.Vector;
import Renderer.ImageWriter;
import Renderer.Render;
import Scene.Scene;

import java.awt.*;

import static org.junit.Assert.*;

/**
 * Created by Adam on 6/27/2017.
 */
public class cubeTest {

    @Test
    public void basicRender()  {
        Scene scene = new Scene();
        scene.setScreenDistance(35);
        Camera cam=new Camera(scene.getCamera());
        cam.setP0(new Point3D(500,0,1));//(0,0,1)
        cam.set_vUp(new Vector(1,0,0));//(1,0,0)
        cam.set_vTo(new Vector(-7,0,-1));//(0,0,-1)
        scene.setCamera(cam);


        Quadrangle face=new Quadrangle(new Point3D(200,-200,-49),new Point3D(200,200,-49),new Point3D(-100,200,-49),new Point3D(-100,-200,-49));//(1,2,4,3)
        Quadrangle face1=new Quadrangle(new Point3D(200,200,-49),new Point3D(200,250,-53),new Point3D(-100,250,-53),new Point3D(-100,200,-49));//(2,6,5,4)
        Quadrangle face2=new Quadrangle(new Point3D(200,-200,-49),new Point3D(200,-150,-53),new Point3D(200,250,-53),new Point3D(200,200,-49));//(1,7,6,2)
        Quadrangle face3=new Quadrangle(new Point3D(-100,250,-53),new Point3D(200,250,-53),new Point3D(200,-150,-53),new Point3D(-100,-150,-53));//(5,6,7,8)
        Quadrangle face4=new Quadrangle(new Point3D(200,-200,-49),new Point3D(200,-150,-53),new Point3D(-100,-150,-53),new Point3D(-100,-200,-49));//(1,7,8,3)
        Quadrangle face5=new Quadrangle(new Point3D(-100,-200,-49),new Point3D(-100,-150,-53),new Point3D(-100,250,-53),new Point3D(-100,200,-49));//(3,8,5,4)
        Quadrangle face6=new Quadrangle(new Point3D(-1000,-1000,-60),new Point3D(1000,-1000,-65),new Point3D(1000,1000,-65),new Point3D(-1000,1000,-60));
        Quadrangle face7=new Quadrangle(new Point3D(300,5,-50.5),new Point3D(300,25,-50.5),new Point3D(200,25,-50.5),new Point3D(200,5,-50.5));//(16,17,11,10)
        Quadrangle face8=new Quadrangle(new Point3D(300,25,-50.5),new Point3D(300,32,-51.5),new Point3D(200,32,-51.5),new Point3D(200,25,-50.5));//(17,14,12,11)
        Quadrangle face9=new Quadrangle(new Point3D(300,32,-51.5),new Point3D(300,12,-51.5),new Point3D(300,5,-50.5),new Point3D(300,25,-50.5));//(14,15,16,17)

//Triangle
        Triangle trg = new Triangle(new Point3D( -100,-200,-49), new Point3D(  -100,200,-49), new Point3D( -300,0,-51));//(3.4.9)
        Triangle trg1 = new Triangle(new Point3D( -100,200,-49), new Point3D( -100,250,-53), new Point3D( -300,0,-51));//(4.5.9)
        Triangle trg2 = new Triangle( new Point3D(  -100,250,-53), new Point3D( -100,-150,-53), new Point3D( -300,0,-51));//(589)
        Triangle trg3 = new Triangle(new Point3D( -100,-200,-49), new Point3D(  -100,-150,-53), new Point3D( -300,0,-51));//(389)

        trg.setEmmission(new Color(255, 19, 34));
        trg1.setEmmission(new Color(92, 255, 28));
        trg2.setEmmission(new Color(138, 138, 138));
        trg3.setEmmission(new Color(138, 138, 138));

        face.setEmmission(new Color(255, 19, 34));
        face1.setEmmission(new Color(92, 255, 28));
        face2.setEmmission(new Color(15, 122, 255));
        face3.setEmmission(new Color(255, 235, 5));
        face4.setEmmission(new Color(255, 14, 226));
        face5.setEmmission(new Color(61, 255, 240));
        face6.setEmmission(new Color(255, 15, 165));
        face7.setEmmission(new Color(199, 255, 17));
        face8.setEmmission(new Color(255, 106, 57));
        face9.setEmmission(new Color(11, 21, 255));


        scene.addGeometry(trg);
        scene.addGeometry(trg1);
        scene.addGeometry(trg2);
        scene.addGeometry(trg3);
        scene.addGeometry(face);
        scene.addGeometry(face1);
        scene.addGeometry(face2);
        scene.addGeometry(face3);
        scene.addGeometry(face4);
        scene.addGeometry(face5);
        scene.addGeometry(face6);
        scene.addGeometry(face7);
        scene.addGeometry(face8);
        scene.addGeometry(face9);
        //scene.addLight(new SpotLight(new Color(255, 252, 204), new Point3D(300, 200, 10),new Vector(-2, -2, -3), 0, 0.000001, 0.0000005));
        scene.addLight(new PointLight(new Color(255, 183, 138),new Point3D(100,-200,0),0, 0.000001, 0.0000005));
       // scene.addLight(new PointLight(new Color(255, 183, 138),new Point3D(100,200,0),0, 0.000001, 0.0000005));

        scene.getAmbientLight();
        ImageWriter imageWriter = new ImageWriter("cube test", 500, 500, 500, 500);

        Render render = new Render(imageWriter, scene);

        render.renderImage();
        // render.printGrid(15);
        render.writeToImage();

    }

}
