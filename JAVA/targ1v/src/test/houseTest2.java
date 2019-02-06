package test;

import Elements.AmbientLight;
import Elements.PointLight;
import Elements.SpotLight;
import Geometries.*;
import Geometries.Rectangle;
import Primitives.Point3D;
import Primitives.Vector;
import Renderer.ImageWriter;
import Renderer.Render;
import Scene.Scene;
import org.junit.Test;

import java.awt.*;

import static org.junit.Assert.*;

/**
 * Created by HC on 16/06/2017.
 */
public class houseTest2 {
    @Test
    public void basicRender()  {
        Scene scene = new Scene();
        scene.setScreenDistance(35);

        //Sphere
        //Sphere sphere = new Sphere(30, new Point3D(400, 300, -150));

        //Triangle
        Triangle toutEnBasGauche = new Triangle(new Point3D( -245, -350, -65), new Point3D(  -268, -350, -65), new Point3D( -268, -120, -49));//(2,1,3)
        Triangle basGauche = new Triangle(new Point3D( -245, -350, -65), new Point3D(  -245, -120, -49), new Point3D( -268, -120, -49));//(2,4,3)
        Triangle toutEnBasDroit = new Triangle( new Point3D(  -245, -120, -49), new Point3D( -268, -120, -49), new Point3D( -268, 300, -65));//(4,3,5)
        Triangle basDroit = new Triangle(new Point3D( -245, 300, -65), new Point3D(  -268, 300, -65), new Point3D( -245, -120, -49));//(6,5,4)
        Triangle toutDroit = new Triangle( new Point3D(  120, -350, -65), new Point3D( -245, -350, -65), new Point3D( -245, -290, -60.8));//(7,2,9)
        Triangle Droit = new Triangle(new Point3D( 120, -350, -65), new Point3D(  120, -290, -60.8), new Point3D( -245, -290, -60.8));//(7,8,9)
        Triangle haut = new Triangle(new Point3D( 120, -350, -65), new Point3D(  200,-185,-57), new Point3D( 120,-120,-49));//(7,20,11)
        Triangle soleil = new Triangle(new Point3D( 800, 250, -90), new Point3D(  300,700,-90), new Point3D( 600,600,-90));//(7,20,11)
        Triangle chausse = new Triangle(new Point3D( -650,-1000,-90.1), new Point3D(  -250,1000,-90.1), new Point3D( -1000,1000,-90));//(7,20,11)

        // Rectangle rec1= new Rectangle(new Point3D(200,200,-80),new Point3D(300,300,-80));

        //Quadrangle
        Quadrangle grandMur=new Quadrangle(new Point3D(-245,30,-55),new Point3D(30,30,-55),new Point3D(30,300,-65),new Point3D(-245,300,-65));//(21,24,17,6)
        Quadrangle milieuDroit=new Quadrangle(new Point3D(-245,-120,-49),new Point3D(30,-120,-49),new Point3D(30,-50,-51.5),new Point3D(-245,-50,-51.5));//(4,25,18,19)
        Quadrangle linteau=new Quadrangle(new Point3D(30,-120,-49),new Point3D(120,-120,-49),new Point3D(120,300,-65),new Point3D(30,300,-65));//(25,11,16,17)
        Quadrangle sol=new Quadrangle(new Point3D(-245, -350, -65),new Point3D(-245, -120, -49),new Point3D(-245,300,-65),new Point3D(-245,170,-81));//(2,4,6,coinDuFondBas)
        Quadrangle murDuFond=new Quadrangle(new Point3D(-245, -350, -65),new Point3D(120, -350, -65),new Point3D(120,170,-81),new Point3D(-245,170,-81));//(2,7,coinDuFondHaut,coinDuFondBas)
       /*a revoir*/ //Quadrangle quad3=new Quadrangle(new Point3D(-245,30,-54),new Point3D(30,30,-54),new Point3D(-245,30,-60),new Point3D(30,30,-60));//(21,24,(21,24 plus profond))
        Quadrangle roof=new Quadrangle(new Point3D(200,-190,-56),new Point3D(100,-118,-46),new Point3D(114,310,-63),new Point3D(200,235,-73));//(20,11,16,22)
        Quadrangle roof1=new Quadrangle(new Point3D(200,-190,-56),new Point3D(110, -385, -66),new Point3D(120,170,-81),new Point3D(200,235,-73));//(20,7,coinDuFondHaut,22)
        Quadrangle milieuGauche=new Quadrangle(new Point3D(120,-163,-52),new Point3D(120,-120,-49),new Point3D(-245, -120, -49),new Point3D(-245,-163,-52));//(10,11,4,12)
        Quadrangle dessusFenetre=new Quadrangle(new Point3D(120,-163,-52),new Point3D(-3,-163,-52),new Point3D(-3, -290, -60.8),new Point3D(120, -290, -60.8));//(10,14,13,8)
        Quadrangle dessousFenetre=new Quadrangle(new Point3D(-245, -290, -60.8),new Point3D(-120,-290,-60.8),new Point3D(-120, -163, -52),new Point3D(-245,-163,-52));//(9,23,15,12)
        Quadrangle murArriere=new Quadrangle(new Point3D(120,300,-65),new Point3D(-245,300,-65),new Point3D(-245,170,-81),new Point3D(120,170,-81));//(16,6,coinDuFondBas,coinDuFondHaut)
        Quadrangle ciel=new Quadrangle(new Point3D(120,-1000,-90.1),new Point3D(1000,-1000,-90.1),new Point3D(1000,1000,-90.1),new Point3D(120,1000,-90.1));
        Quadrangle pelouse=new Quadrangle(new Point3D(120,-1000,-90.1),new Point3D(120,1000,-90.1),new Point3D(-250,1000,-90.1),new Point3D(-650,-1000,-90.1));
//pelouse.setKt(1);
        //   roof.getMaterial().setKr(1);

        toutEnBasGauche.setEmmission(new Color(187,187,187));//+bas gauche
        basGauche.setEmmission(new Color(187,187,187));//bas gauche
        toutEnBasDroit.setEmmission(new Color(187,187,187));//+bas droite
        basDroit.setEmmission(new Color(212, 212, 212));//bas droite
        toutDroit.setEmmission(new Color(187,187,187));//mur triangulaire le ++ a gauche
        Droit.setEmmission(new Color(187,187,187));//mur triangulaire le + gauche
        haut.setEmmission(new Color(187,187,187));//mur triangulaire le + gauche
        soleil.setEmmission(new Color(255, 239, 30));//mur triangulaire le + gauche
        chausse.setEmmission(new Color(96, 96, 96));//mur triangulaire le + gauche


        grandMur.setEmmission(new Color(187,187,187));//mur a droite de la porte
        milieuDroit.setEmmission(new Color(187,187,187));//mur a gauche de la porte
        linteau.setEmmission(new Color(187, 187, 187));//mur au dessus de la porte
        //quad3.setEmmission(new Color(104, 187, 182));
        milieuGauche.setEmmission(new Color(187,187,187));//mur a droite de la fenetre
        dessusFenetre.setEmmission(new Color(187, 187, 187));//mur au dessus de la fenetre
        dessousFenetre.setEmmission(new Color(187,187,187));//mur en dessous de la fenetre
        murArriere.setEmmission(new Color(187, 187,187));//mur arriere
        ciel.setEmmission(new Color(150, 187, 186));
        pelouse.setEmmission(new Color(26, 132, 31));

        sol.setEmmission(new Color(175, 175, 175));//sol
        murDuFond.setEmmission(new Color(146, 146, 146));//mur du fond
        roof.setEmmission(new Color(255, 65, 65));//toit de droite
        roof1.setEmmission(new Color(255, 65, 65));//toit de gauche

        // sphere.setEmmission(new Color(255, 239, 30));

        //  scene.addGeometry(sphere);
        scene.addGeometry(toutEnBasGauche);
        scene.addGeometry(basGauche);
        scene.addGeometry(toutEnBasDroit);
        scene.addGeometry(basDroit);
        scene.addGeometry(toutDroit);
        scene.addGeometry(Droit);
        scene.addGeometry(haut);
        scene.addGeometry(grandMur);
        scene.addGeometry(milieuDroit);
        scene.addGeometry(linteau);
        //  scene.addGeometry(quad3);
        scene.addGeometry(milieuGauche);
        scene.addGeometry(dessusFenetre);
        scene.addGeometry(dessousFenetre);
        scene.addGeometry(murArriere);
        scene.addGeometry(sol);
        scene.addGeometry(roof);
        scene.addGeometry(roof1);
        scene.addGeometry(murDuFond);
        // scene.addGeometry(soleil);
        scene.addGeometry(ciel);
        scene.addGeometry(pelouse);
        scene.addGeometry(chausse);


        //scene.addLight(new SpotLight(new Color(255, 252, 204), new Point3D(300, 200, 10),new Vector(-2, -2, -3), 0, 0.000001, 0.0000005));
        scene.addLight(new PointLight(new Color(255, 183, 138),new Point3D(150,200,0),0, 0.000001, 0.0000005));

        scene.getAmbientLight();
        ImageWriter imageWriter = new ImageWriter("House test", 500, 500, 500, 500);

        Render render = new Render(imageWriter, scene);

        render.renderImage();
        // render.printGrid(15);
        render.writeToImage();

    }


}