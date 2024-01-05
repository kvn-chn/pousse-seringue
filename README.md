# Pousse-Seringue

![pousseseringue](https://github.com/kvn-chn/pousse-seringue/assets/139592148/a5bfb479-20fe-4b07-8901-13b35147b823)

Projet de fin d'année réalisé en 2023 pour une durée de 6 mois.

Langages utilisés: MikroC, C#, MySQL
Logiciels utilisés: Visual Studio, MikroC Pro

# Contexte du projet 

![ps](https://github.com/kvn-chn/pousse-seringue/assets/139592148/7f61c345-f8b5-4a2d-b519-5415b5fb57fb)

Un pousse-seringue est une petite pompe à perfusion, utilisée dans le domaine hospitalier pour administrer de petites quantités de liquide à un débit lent et constant pendant une certaine durée. 
Bien que ce pousse-seringue de modèle SE 200 soit tout à fait fonctionnelle, on y trouve quelques configurations notamment : le choix du type de seringue à gauche, le réglage du débit moteur à droite et un bouton démarrage/arrêt. A vue d'œil, tout semble correct. Cependant on se demanderait si ce ne serait pas envisageable de l’améliorer en y ajoutant une interface graphique et avoir la possibilité de stocker les données des injections effectuées ou en cours sur une base de données.
L’objectif de ce projet a été donc de piloter le pousse-seringue avec un système embarqué, concevoir une IHM de configuration et créer une base de données.

<img width="711" alt="Capture d’écran 2024-01-05 à 22 05 25" src="https://github.com/kvn-chn/pousse-seringue/assets/139592148/c88b2258-266b-4a53-9448-a9db3e940c26">

# Objectif du projet 

* Réaliser un pilotage et une configuration d’un pousse-seringue par le moyen d’une interface graphique.
* Surveillance de l'appareil au niveau d’un service hospitalier de toutes les injections automatiques en cours.
* Gestion d'une base de données pour l'administration des patients.

# Fonctionnement du pousse-seringue 

![ps-fonctionnement](https://github.com/kvn-chn/pousse-seringue/assets/139592148/bda0a371-b7aa-44a5-88f9-75f5c7928e22)

Le pousse-seringue possède un moteur électrique pas à pas, doté d’un réducteur de vitesse qui est entraîné par plusieurs engrenages, qui est lié à un engrenage conique qui permet de changer l’axe de rotation qui est entraîné par le moteur et on trouve un système vis-écrou qui vient transformer le mouvement de rotation en un mouvement de translation qui devient une liaison hélicoïdale et poussera la tige de la seringue.

# Logiciels utilisés 

<img width="879" alt="Capture d’écran 2024-01-05 à 22 16 22" src="https://github.com/kvn-chn/pousse-seringue/assets/139592148/1c5861bd-5834-408e-b50d-f1848ad4f81c">

# Scénario théorique 

<img width="1141" alt="Capture d’écran 2024-01-05 à 22 17 08" src="https://github.com/kvn-chn/pousse-seringue/assets/139592148/4bbefc0a-52e2-4780-8463-a042b61056d3">
