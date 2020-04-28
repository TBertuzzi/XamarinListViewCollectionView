# Migre de ListView para Collection View

Este exemplo ensina como utilizar as funcionalidades do CollectionView para não precisar mais do ListView.

O Xamarin.Forms  presenteou com a Incrivel CollectionView ( [Mais informações clique aqui](https://medium.com/@bertuzzi/o-x-do-xamarin-forms-4-0-collectionview-e-carouselview-2c277f61d063) ), ela trouxe algumas diferenças em relação ao ListView.

* É possivel configurar a exibição dos dados de forma vertical ou horizontalmente.
* Não Utiliza o Conceito de Celulas, você pode configurar a exibição de acordo com seu template de dados.
* Não inclui separadores internos.
* Mais diferenças [clicando aqui](https://docs.microsoft.com/pt-br/xamarin/xamarin-forms/user-interface/collectionview/introduction)

Para ajudar a realizar as implementações criei esse Repositorio com um Aplicativo com o ListView e as implementações possiveis do Mesmo ( e funcionalidades novas) na CollectionView.

* [ListViewPage.xaml](https://github.com/TBertuzzi/XamarinListViewCollectionView/blob/master/XamarinListViewCollectionView/XamarinListViewCollectionView/Views/ListViewPage.xaml) : Implementação da Antiga ListView para ser utilizada como base.

* [CollectionViewPage.xaml](https://github.com/TBertuzzi/XamarinListViewCollectionView/blob/master/XamarinListViewCollectionView/XamarinListViewCollectionView/Views/CollectionViewPage.xaml) : Nova forma de Implementar a Collection View.

* [RefreshCollectionViewPage.xaml](https://github.com/TBertuzzi/XamarinListViewCollectionView/blob/master/XamarinListViewCollectionView/XamarinListViewCollectionView/Views/RefreshCollectionViewPage.xaml) : Como Implementar a RefreshView para exibir o cursor de Espera na ListView.

* [SwipeCollectionViewPag.xaml](https://github.com/TBertuzzi/XamarinListViewCollectionView/blob/master/XamarinListViewCollectionView/XamarinListViewCollectionView/Views/SwipeCollectionViewPage.xaml) : Como Implementar a SwipeView para Submenus na CollectionView.

# 🚧 Em Construção