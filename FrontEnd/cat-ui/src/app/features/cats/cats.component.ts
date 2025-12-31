import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CatsService } from '../../core/services/cat.service';

@Component({
  selector: 'app-cats',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './cats.component.html',
  styleUrls: ['./cats.component.css']
})
export class CatsComponent implements OnInit {

  breeds: any[] = [];
  selectedBreedId: string | null = null;
  selectedBreed: any = null;

  images: any[] = [];
  currentIndex = 0;

  constructor(private catsService: CatsService) {}

  ngOnInit(): void {
    this.catsService.getBreeds().subscribe((breeds: any[]) => {
      this.breeds = breeds;
    });
  }

  onBreedChange(): void {
    this.selectedBreed = this.breeds.find(
      b => b.id === this.selectedBreedId
    );

    this.currentIndex = 0;

    if (!this.selectedBreedId) return;

    this.catsService
      .getImagesByBreed(this.selectedBreedId)
      .subscribe((images: any[]) => {
        this.images = images;
      });
  }

  next(): void {
    if (!this.images.length) return;
    this.currentIndex = (this.currentIndex + 1) % this.images.length;
  }

  prev(): void {
    if (!this.images.length) return;
    this.currentIndex =
      (this.currentIndex - 1 + this.images.length) % this.images.length;
  }
}
