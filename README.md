# GLScoreMaker
Logiciel utilis� pour calculer le score lors de races Super Mario Maker.

Les r�gles de bases sont les suivantes :
Lors d'une race des 100 marios sur Super Mario Maker, un score est attribu� � chaque joueur de la race. Ce score varie en fonction du nombre de levels r�ussis,
de skips et du nombre de morts. Les points pour les morts ne sont compt�s que toutes les dix morts ! Toute mort ou skip ne compte que si le score est sup�rieur � 0 ! (i.e. On ne peut avoir un score n�gatif).
ATTENTION ! Cette derni�re r�gle est importante, en effet, deux personnes ayant le m�me nombre de levels r�ussis, morts et skips peuvent avoir un score diff�rent !
L'ordre est donc extr�mement important ! C'est pourquoi il est FORTEMENT DECONSEILLE d'utiliser le logiciel en milieu de Run ! 
A moins de remettre les points dans le bon ordre !

Les valeurs par d�faut sont :
- +10 par level r�ussi
- -2 par skip
- -5 toutes les 10 morts
  

Raccourcis clavier:
- "Espace" pour ajouter une mort
- "s" pour ajouter un skip
- "l" pour ajouter un level
- CTRL+Z pour annuler la derni�re modification
- CTRL+Y pour r�tablir la derni�re modification

Vous pouvez changez le nombre de points gagn�s/perdus pour les morts, skips et level r�ussis en selectionnant Configuration dans le menu en haut. Cependant, changer ces
valeurs REINITIALISERA le score et les compteurs !

Le logiciel sauvegarde la derni�re configuration et la recharge au lancement. Ces informations sont pr�sentes dans le fichier config.xml. Si celui-ci est supprim� par 
m�garde (ou m�chancet� pure :( ), il sera recr�� au lancement de l'Application avec les valeurs par d�faut.

A chaque utilisation du logiciel, un fichier data.txt est cr�� � l'emplacement du .exe . Celui-ci contient les diff�rentes informations sur le score et les compteurs
dans le but d'�tre r�cup�r�es sur XSplit/OBS pour apr�s les afficher sur un stream.

PROBLEMES : 
Si l'Application ne sauvegarde pas les changements de configuration et ne change pas les valeurs du fichier data.txt, c'est probablement une question de droit d'�criture !
Essayez de lancer l'Application en mode Administrateur ou bien de d�placer tout le dossier dans un endroit ou vous avez tous les droits ! (Par exemple un autre disque que C:)

Si toutefois vous rencontrez d'autres probl�me ou voulez proposez une modification/am�lioration, n'h�sitez pas � me joindre sur twitter @Sirignus. 

Bonne race !

Cr�� par Thomas "Sirignus" Cochat (@Sirignus).

Ce logiciel est utilisable gratuitement par n'importe qui !